import * as THREE from 'https://cdn.skypack.dev/three@0.132.2';

// Scene
const scene = new THREE.Scene();
scene.background = new THREE.Color(0x66ccff);

// Camera (Starts behind the car)
const camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);
camera.position.set(0, 5, -10);

// Renderer
const renderer = new THREE.WebGLRenderer({ antialias: true });
renderer.setSize(window.innerWidth, window.innerHeight);
renderer.shadowMap.enabled = true;
document.body.appendChild(renderer.domElement);

// Lights
const ambientLight = new THREE.AmbientLight(0xffffff, 0.6);
scene.add(ambientLight);

const directionalLight = new THREE.DirectionalLight(0xffffff, 0.8);
directionalLight.position.set(20, 50, 20);
directionalLight.castShadow = true;
directionalLight.shadow.mapSize.width = 2048;
directionalLight.shadow.mapSize.height = 2048;
scene.add(directionalLight);

// Physics World
const world = new CANNON.World();
world.gravity.set(0, -9.82, 0);
world.broadphase = new CANNON.SAPBroadphase(world);

// Ground
const groundGeometry = new THREE.PlaneGeometry(200, 200);
const groundMaterial = new THREE.MeshStandardMaterial({ color: 0x808080 });
const ground = new THREE.Mesh(groundGeometry, groundMaterial);
ground.rotation.x = -Math.PI / 2;
ground.receiveShadow = true;
scene.add(ground);

const groundBody = new CANNON.Body({
    mass: 0,
    shape: new CANNON.Plane(),
});
groundBody.quaternion.setFromAxisAngle(new CANNON.Vec3(1, 0, 0), -Math.PI / 2);
world.addBody(groundBody);

// --- Car Setup ---
const chassisShape = new CANNON.Box(new CANNON.Vec3(1, 0.5, 2));
const chassisBody = new CANNON.Body({ mass: 150 });
chassisBody.addShape(chassisShape);
chassisBody.position.set(0, 4, 0);
chassisBody.angularDamping = 0.5;

const vehicle = new CANNON.RaycastVehicle({
    chassisBody: chassisBody,
});

const wheelOptions = {
    radius: 0.5,
    directionLocal: new CANNON.Vec3(0, -1, 0),
    suspensionStiffness: 30,
    suspensionRestLength: 0.3,
    frictionSlip: 1.4,
    dampingRelaxation: 2.3,
    dampingCompression: 4.4,
    maxSuspensionForce: 100000,
    rollInfluence: 0.01,
    axleLocal: new CANNON.Vec3(-1, 0, 0), // Fix axle direction
    chassisConnectionPointLocal: new CANNON.Vec3(1, 1, 0),
    maxSuspensionTravel: 0.3,
    customSlidingRotationalSpeed: -30,
    useCustomSlidingRotationalSpeed: true,
};

// Add Wheels
wheelOptions.chassisConnectionPointLocal.set(1, 0, 1.5);
vehicle.addWheel(wheelOptions);

wheelOptions.chassisConnectionPointLocal.set(-1, 0, 1.5);
vehicle.addWheel(wheelOptions);

wheelOptions.chassisConnectionPointLocal.set(1, 0, -1.5);
vehicle.addWheel(wheelOptions);

wheelOptions.chassisConnectionPointLocal.set(-1, 0, -1.5);
vehicle.addWheel(wheelOptions);

vehicle.addToWorld(world);

// Car Visuals
const wheelBodies = [];
const wheelMaterial = new THREE.MeshStandardMaterial({ color: 0x333333 });
const wheelGeometry = new THREE.CylinderGeometry(0.5, 0.5, 0.5, 32);
wheelGeometry.rotateZ(Math.PI / 2); // Fix wheel rotation

const wheelMeshes = [];
for(let i=0; i<4; i++){
    const wheel = new THREE.Mesh(wheelGeometry, wheelMaterial);
    wheel.castShadow = true;
    scene.add(wheel);
    wheelMeshes.push(wheel);
}

function createCarModel() {
    const carGroup = new THREE.Group();

    const main = new THREE.Mesh(
        new THREE.BoxGeometry(2, 0.8, 4),
        new THREE.MeshStandardMaterial({ color: 0xbb0000 })
    );
    main.castShadow = true;
    carGroup.add(main);

    const cabin = new THREE.Mesh(
        new THREE.BoxGeometry(1.6, 0.7, 2),
        new THREE.MeshStandardMaterial({ color: 0xffffff })
    );
    cabin.position.set(0, 0.75, -0.2);
    cabin.castShadow = true;
    carGroup.add(cabin);

    return carGroup;
}

const carMesh = createCarModel();
scene.add(carMesh);

// Obstacles
const obstacles = [];
function createObstacle(x, y, z) {
    const obstacleGeometry = new THREE.BoxGeometry(2, 2, 2);
    const obstacleMaterial = new THREE.MeshStandardMaterial({ color: 0x0000ff });
    const obstacleMesh = new THREE.Mesh(obstacleGeometry, obstacleMaterial);
    
    const obstacleShape = new CANNON.Box(new CANNON.Vec3(1, 1, 1));
    const obstacleBody = new CANNON.Body({ mass: 50, shape: obstacleShape });
    
    obstacleBody.position.set(x, y, z);
    obstacleMesh.position.copy(obstacleBody.position);
    
    obstacleMesh.castShadow = true;
    scene.add(obstacleMesh);
    world.addBody(obstacleBody);

    obstacles.push({ mesh: obstacleMesh, body: obstacleBody });
}

createObstacle(5, 1, 10);
createObstacle(-5, 1, -5);
createObstacle(0, 1, -20);

// Controls
const keys = { w: false, s: false, a: false, d: false, ' ': false };

document.addEventListener('keydown', (e) => {
    if (keys.hasOwnProperty(e.key.toLowerCase())) keys[e.key.toLowerCase()] = true;
    if (e.key === ' ') keys[' '] = true;
});

document.addEventListener('keyup', (e) => {
    if (keys.hasOwnProperty(e.key.toLowerCase())) keys[e.key.toLowerCase()] = false;
    if (e.key === ' ') keys[' '] = false;
});

// Animation Loop
const clock = new THREE.Clock();

function animate() {
    requestAnimationFrame(animate);

    const delta = clock.getDelta();
    // Use a fixed time step for physics to prevent instability
    world.step(1 / 60, delta, 3);

    // Car Physics
    const maxSteerVal = 0.5;
    const maxForce = 1500;
    const brakeForce = 25;

    // Reset controls
    vehicle.setSteeringValue(0, 0);
    vehicle.setSteeringValue(0, 1);
    vehicle.applyEngineForce(0, 2);
    vehicle.applyEngineForce(0, 3);
    vehicle.setBrake(0, 0);
    vehicle.setBrake(0, 1);
    vehicle.setBrake(0, 2);
    vehicle.setBrake(0, 3);

    // Drive
    if (keys.w) {
        vehicle.applyEngineForce(-maxForce, 2);
        vehicle.applyEngineForce(-maxForce, 3);
    } else if (keys.s) {
        vehicle.applyEngineForce(maxForce, 2);
        vehicle.applyEngineForce(maxForce, 3);
    }

    // Steer
    if (keys.a) {
        vehicle.setSteeringValue(maxSteerVal, 0);
        vehicle.setSteeringValue(maxSteerVal, 1);
    } else if (keys.d) {
        vehicle.setSteeringValue(-maxSteerVal, 0);
        vehicle.setSteeringValue(-maxSteerVal, 1);
    }

    // Brake
    if (keys[' ']) {
        vehicle.setBrake(brakeForce, 2);
        vehicle.setBrake(brakeForce, 3);
    }

    // Sync Visuals
    carMesh.position.copy(chassisBody.position);
    carMesh.quaternion.copy(chassisBody.quaternion);

    for (let i = 0; i < vehicle.wheelInfos.length; i++) {
        vehicle.updateWheelTransform(i);
        const t = vehicle.wheelInfos[i].worldTransform;
        wheelMeshes[i].position.copy(t.position);
        wheelMeshes[i].quaternion.copy(t.quaternion);
    }

    obstacles.forEach(o => {
        o.mesh.position.copy(o.body.position);
        o.mesh.quaternion.copy(o.body.quaternion);
    });

    // Chase Camera Logic
    // 1. Calculate where the camera should be (behind the car)
    const relativeCameraOffset = new THREE.Vector3(0, 5, 10);
    const cameraOffset = relativeCameraOffset.applyMatrix4(carMesh.matrixWorld);

    // 2. Smoothly move camera there
    camera.position.lerp(cameraOffset, 0.1);
    
    // 3. Look at the car
    camera.lookAt(carMesh.position);

    renderer.render(scene, camera);
}

// Window Resize
window.addEventListener('resize', () => {
    camera.aspect = window.innerWidth / window.innerHeight;
    camera.updateProjectionMatrix();
    renderer.setSize(window.innerWidth, window.innerHeight);
});

animate();