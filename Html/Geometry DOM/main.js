import * as THREE from 'three';
import * as CANNON from 'cannon-es';

// --- 1. SETUP ---
const scene = new THREE.Scene();
scene.background = new THREE.Color(0x22aaff);
const camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);
const renderer = new THREE.WebGLRenderer({ antialias: true });
renderer.setSize(window.innerWidth, window.innerHeight);
document.body.appendChild(renderer.domElement);

const world = new CANNON.World({ gravity: new CANNON.Vec3(0, -40, 0) });

// --- 2. WIDE CHASSIS ---
const chassisBody = new CANNON.Body({ mass: 150 });
chassisBody.addShape(new CANNON.Box(new CANNON.Vec3(1, 0.25, 2))); 
chassisBody.position.set(0, 1, 0);
chassisBody.angularDamping = 0.99; // Keeps steering "snappy" not "drifty"
world.addBody(chassisBody);

const carMesh = new THREE.Mesh(
    new THREE.BoxGeometry(2, 0.5, 4),
    new THREE.MeshStandardMaterial({ color: 0xffff00 }) // Bright Poly Yellow
);
scene.add(carMesh);

// --- 3. THE WIDE WHEEL BASE ---
const vehicle = new CANNON.RaycastVehicle({ chassisBody });

const wheelOptions = {
    radius: 0.5,
    directionLocal: new CANNON.Vec3(0, -1, 0),
    suspensionStiffness: 150,
    suspensionRestLength: 0.2,
    frictionSlip: 12, // Extreme grip
    dampingCompression: 4.5,
    dampingRelaxation: 2.5,
    axleLocal: new CANNON.Vec3(1, 0, 0),
};

// Pushing wheels out to X = 1.5 (0.5 units outside the body)
const wheelPositions = [
    new CANNON.Vec3(1.5, 0, 1.5), new CANNON.Vec3(-1.5, 0, 1.5), // Front
    new CANNON.Vec3(1.5, 0, -1.5), new CANNON.Vec3(-1.5, 0, -1.5) // Rear
];



const wheelMeshes = [];
wheelPositions.forEach(pos => {
    wheelOptions.chassisConnectionPointLocal.copy(pos);
    vehicle.addWheel(wheelOptions);
    const wMesh = new THREE.Mesh(
        new THREE.CylinderGeometry(0.5, 0.5, 0.6, 20), // Wider tires
        new THREE.MeshStandardMaterial({ color: 0x111111 })
    );
    wMesh.geometry.rotateZ(Math.PI / 2);
    wheelMeshes.push(wMesh);
    scene.add(wMesh);
});
vehicle.addToWorld(world);

// --- 4. LIGHT & INPUT ---
scene.add(new THREE.AmbientLight(0xffffff, 1));
const keys = { w: false, s: false, a: false, d: false, space: false };
window.addEventListener('keydown', e => { if (e.key.toLowerCase() in keys) keys[e.key.toLowerCase()] = true; });
window.addEventListener('keyup', e => { if (e.key.toLowerCase() in keys) keys[e.key.toLowerCase()] = false; });

// --- 5. ANIMATION ---
function animate() {
    requestAnimationFrame(animate);
    world.fixedStep();

    // Direct Force Logic
    const engineForce = keys.w ? -15000 : (keys.s ? 8000 : 0);
    const steer = keys.a ? 0.45 : (keys.d ? -0.45 : 0);

    for (let i = 0; i < 4; i++) {
        vehicle.applyEngineForce(engineForce, i);
        // Instant stop logic for arcade feel
        if (!keys.w && !keys.s) vehicle.setBrake(25, i);
        else vehicle.setBrake(0, i);
    }
    
    vehicle.setSteeringValue(