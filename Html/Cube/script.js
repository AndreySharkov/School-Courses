document.addEventListener('DOMContentLoaded', () => {
    const cube = document.querySelector('.cube');
    const gameWorld = document.querySelector('.game-world');
    
    let obstacles = document.querySelectorAll('.obstacle'); 
    let orbs = document.querySelectorAll('.orb');
    let spikes = document.querySelectorAll('.spike');
    
    const box1 = document.querySelector('.textbox1');
    const box2 = document.querySelector('.textbox2');
    const box3 = document.querySelector('.textbox3');

    // --- LEVEL GENERATION: SPIKES ---
    function createSpikeRow(startX, count) {
        for (let i = 0; i < count; i++) {
            const spike = document.createElement('div');
            spike.classList.add('spike');
            spike.style.left = `${startX + (i * 50)}px`; 
            spike.style.bottom = '40px'; 
            gameWorld.appendChild(spike);
        }
    }

    // 1. Warm Up Pit
    createSpikeRow(1000, 6); 
    
    // 2. Long Jump Pit
    createSpikeRow(1700, 14);

    // 3. Floating Archipelago Pit (Huge gap)
    createSpikeRow(4300, 50);

    // 4. Sky Climb Pit
    createSpikeRow(8500, 30);

    // 5. THE FINALE PIT (Under the final 3 Orbs)
    // Starts right after the last platform (10700px) and goes to the tower (12500px)
    createSpikeRow(10700, 38);

    spikes = document.querySelectorAll('.spike'); 

    // --- PHYSICS SETTINGS ---
    const maxSpeed = 12;   
    const acceleration = 0.8; 
    const friction = 0.15;    
    const gravity = 1.5;   
    const jumpVelocity = -20; 
    const orbJumpVelocity = -25; 

    // --- STATE VARIABLES ---
    let cubePositionX = 100;   
    let cubePositionY = 0;   
    let velocityX = 0;       
    let velocityY = 0;      
    let isJumping = false;   
    let isOnGround = true;  
    
    let isJumpKeyPressed = false;
    let isMovingRight = false;
    let isMovingLeft = false;

    let coyoteTimer = 0;      
    const coyoteDuration = 6; 

    let currentOrb = null;
    let intervalId = null;
    let rotation = 0; 

    const cubeHeight = 50;   
    const cubeWidth = 50;
    const groundLevel = window.innerHeight - 40 - cubeHeight;  
    cubePositionY = groundLevel; 

    function updateCubePosition() {
        
        // 1. JUMP LOGIC (Auto-Jump)
        if (isJumpKeyPressed) {
            if (currentOrb) {
                velocityY = orbJumpVelocity;
                isJumping = true;
                isOnGround = false;
                coyoteTimer = 0; 
                currentOrb.classList.remove('active');
                currentOrb = null; 
            } 
            else if (isOnGround || coyoteTimer > 0) {
                velocityY = jumpVelocity;
                isJumping = true;
                isOnGround = false;
                coyoteTimer = 0; 
            }
        }

        // 2. MOVEMENT
        if (isMovingRight) velocityX += acceleration;
        if (isMovingLeft) velocityX -= acceleration;

        if (!isMovingRight && !isMovingLeft) {
            velocityX *= (1 - friction);
            if (Math.abs(velocityX) < 0.1) velocityX = 0;
        }

        velocityX = Math.max(-maxSpeed, Math.min(maxSpeed, velocityX));
        cubePositionX += velocityX;

        // 3. X COLLISIONS
        if (cubePositionX < 0) { cubePositionX = 0; velocityX = 0; }

        obstacles.forEach(obstacle => {
            if (checkCollision(cubePositionX, cubePositionY, obstacle, 0)) { 
                const obsRect = getRect(obstacle);
                if (velocityX > 0) cubePositionX = obsRect.left - cubeWidth;
                else if (velocityX < 0) cubePositionX = obsRect.right;
                velocityX = 0;
            }
        });

        // 4. GRAVITY
        velocityY += gravity;
        cubePositionY += velocityY;

        // 5. Y COLLISIONS
        if (cubePositionY >= groundLevel) {
            cubePositionY = groundLevel;
            velocityY = 0;
            isOnGround = true;
            isJumping = false;
        }

        obstacles.forEach(obstacle => {
            if (checkCollision(cubePositionX, cubePositionY, obstacle, 0)) {
                const obsRect = getRect(obstacle);
                if (velocityY > 0) { 
                    cubePositionY = obsRect.top - cubeHeight;
                    velocityY = 0;
                } else if (velocityY < 0) { 
                    cubePositionY = obsRect.bottom;
                    velocityY = 0;
                }
            }
        });

        // 6. GROUND CHECK
        checkGroundedState();

        if (isOnGround) {
            coyoteTimer = coyoteDuration; 
        } else {
            coyoteTimer--; 
        }

        // 7. ROTATION
        if (!isOnGround) {
            if (velocityX >= 0) rotation += 6;
            else rotation -= 6;
        } else {
            rotation = Math.round(rotation / 90) * 90;
        }

        // 8. SPIKES
        spikes.forEach(spike => {
            if (checkCollision(cubePositionX, cubePositionY, spike, -15)) {
                resetLevel();
            }
        });

        // 9. ORBS
        let touchingAnyOrb = false;
        orbs.forEach(orb => {
            if (checkCollision(cubePositionX, cubePositionY, orb, 20)) { 
                touchingAnyOrb = true;
                currentOrb = orb;
                orb.classList.add('active'); 
            } else {
                orb.classList.remove('active');
            }
        });
        if (!touchingAnyOrb) currentOrb = null;

        // 10. CAMERA
        let cameraOffset = cubePositionX - (window.innerWidth * 0.3);
        if (cameraOffset < 0) cameraOffset = 0;
        gameWorld.style.transform = `translateX(-${cameraOffset}px)`;
        document.querySelector('.background-grid').style.backgroundPosition = `-${cameraOffset * 0.5}px 0`;

        // LINKS
        if (box1 && checkCollision(cubePositionX, cubePositionY, box1, 0)) window.location.href = 'about.html';
        if (box2 && checkCollision(cubePositionX, cubePositionY, box2, 0)) window.location.href = 'projects.html';
        if (box3 && checkCollision(cubePositionX, cubePositionY, box3, 0)) window.location.href = 'contact.html';

        cube.style.left = `${cubePositionX}px`;
        cube.style.top = `${cubePositionY}px`;
        cube.style.transform = `rotate(${rotation}deg)`;
    }

    function checkGroundedState() {
        if (cubePositionY >= groundLevel - 1) { 
            isOnGround = true; isJumping = false; return;
        }
        let onObstacle = false;
        obstacles.forEach(obstacle => {
            if (checkCollision(cubePositionX, cubePositionY + 2, obstacle, 0)) onObstacle = true;
        });
        if (onObstacle && velocityY >= 0) {
            isOnGround = true; isJumping = false;
        } else {
            isOnGround = false;
        }
    }

    function resetLevel() {
        cubePositionX = 100;
        cubePositionY = groundLevel;
        velocityX = 0;
        velocityY = 0;
        rotation = 0; 
        cube.style.transform = `rotate(0deg)`;
    }

    function checkCollision(x, y, target, padding = 0) {
        const targetRect = target.getBoundingClientRect();
        const cameraOffset = Math.abs(new DOMMatrix(window.getComputedStyle(gameWorld).transform).m41);
        
        const tLeft = targetRect.left + cameraOffset - padding;
        const tRight = targetRect.right + cameraOffset + padding;
        const tTop = targetRect.top - padding;
        const tBottom = targetRect.bottom + padding;

        const cLeft = x;
        const cRight = x + cubeWidth;
        const cTop = y;
        const cBottom = y + cubeHeight;

        return (cLeft < tRight && cRight > tLeft && cTop < tBottom && cBottom > tTop);
    }
    
    function getRect(el) {
        const rect = el.getBoundingClientRect();
        const cameraOffset = Math.abs(new DOMMatrix(window.getComputedStyle(gameWorld).transform).m41);
        return {
            left: rect.left + cameraOffset,
            right: rect.right + cameraOffset,
            top: rect.top,
            bottom: rect.bottom
        };
    }

    function handleKeyDown(event) {
        if (event.key === "ArrowRight") isMovingRight = true;
        if (event.key === "ArrowLeft") isMovingLeft = true;
        if (event.key === "ArrowUp" || event.key === " ") isJumpKeyPressed = true;
        
        if (!intervalId) intervalId = setInterval(updateCubePosition, 16);
    }

    function handleKeyUp(event) {
        if (event.key === "ArrowRight") isMovingRight = false;
        if (event.key === "ArrowLeft") isMovingLeft = false;
        if (event.key === "ArrowUp" || event.key === " ") isJumpKeyPressed = false;
    }

    window.addEventListener('keydown', handleKeyDown);
    window.addEventListener('keyup', handleKeyUp);
});