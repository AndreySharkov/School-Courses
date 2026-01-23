document.addEventListener('DOMContentLoaded', () => {
    const cube = document.querySelector('.cube');
    const gameWorld = document.querySelector('.game-world'); // SELECT THE WORLD
    const obstacles = document.querySelectorAll('.obstacle'); 
    const orbs = document.querySelectorAll('.orb');
    
    // Select boxes (make sure these are inside .game-world in HTML)
    const box1 = document.querySelector('.box1');
    const box2 = document.querySelector('.box2');
    const box3 = document.querySelector('.box3');

    const maxSpeed = 12;   
    const acceleration = 2; // Snappier movement
    const friction = 0.8;   // STOPS SLIDING INSTANTLY
    const gravity = 2;   
    const jumpVelocity = -32; 
    const orbJumpVelocity = -28; 

    let cubePositionX = 100; // Start a bit away from the edge   
    let cubePositionY = 0;   
    let velocityX = 0;       
    let velocityY = 0;      
    let isJumping = false;   
    let isOnGround = true;  
    let isOnObstacle = false; 
    let isMovingRight = false;
    let isMovingLeft = false;
    let currentOrb = null;
    let intervalId = null;

    const cubeHeight = 25;   
    const groundLevel = window.innerHeight - cubeHeight - 16;  
    cubePositionY = groundLevel;

    function updateCubePosition() {
        // --- PHYSICS UPDATE ---
        if (isMovingRight) {
            velocityX += acceleration;  
        } 
        if (isMovingLeft) {
            velocityX -= acceleration;  
        }
        
        // Apply Heavy Friction if no keys pressed
        if (!isMovingRight && !isMovingLeft) {
            velocityX *= (1 - friction); // This smooths it to 0 very fast
            if (Math.abs(velocityX) < 0.1) velocityX = 0;
        }

        // Clamp Speed
        velocityX = Math.max(-maxSpeed, Math.min(maxSpeed, velocityX));
        cubePositionX += velocityX;

        // Prevent going off left edge, but allow infinite right movement
        cubePositionX = Math.max(0, cubePositionX); 

        // Gravity
        if (!isOnGround) {
            velocityY += gravity;
            cubePositionY += velocityY;
        }

        // Ground Collision
        if (cubePositionY >= groundLevel && !isOnObstacle) {
            cubePositionY = groundLevel;
            velocityY = 0;
            isOnGround = true;  
            isJumping = false;
        }

        // Obstacle Collision
        obstacles.forEach(obstacle => {
            if (isCollidingTop(cube, obstacle)) {
                handleTopCollision(obstacle);
            } else if (isCollidingSides(cube, obstacle)) {
                handleSideCollision(obstacle);
            }
        });

        // Orb Collision
        checkOrbCollisions();

        // Check if fell off obstacle
        if (isOnObstacle) {
            let isOffObstacle = true;
            obstacles.forEach(obstacle => {
                const obstacleRect = obstacle.getBoundingClientRect();
                const cubeRect = cube.getBoundingClientRect();
                
                // We check overlap relative to the viewport
                if (cubeRect.right > obstacleRect.left && cubeRect.left < obstacleRect.right) {
                    isOffObstacle = false;
                }
            });
            if (isOffObstacle) {
                isOnObstacle = false;
                isOnGround = false; 
            }
        }

        // --- CAMERA FOLLOW LOGIC ---
        // We want the cube to stay roughly 30% into the screen
        let cameraOffset = cubePositionX - (window.innerWidth * 0.3);
        
        // Don't scroll past the start (left side)
        cameraOffset = Math.max(0, cameraOffset);
        
        // Move the entire game world to the left
        gameWorld.style.transform = `translateX(-${cameraOffset}px)`;
        
        // Parallax effect for background (moves slower than foreground)
        document.querySelector('.background-grid').style.backgroundPosition = `-${cameraOffset * 0.2}px center`;


        // Page Redirects (Box collisions)
        if (box1 && isCollidingSides(cube, box1)) window.location.href = 'about.html';
        if (box2 && isCollidingSides(cube, box2)) window.location.href = 'projects.html';
        if (box3 && isCollidingSides(cube, box3)) window.location.href = 'contact.html';

        cube.style.left = `${cubePositionX}px`;
        cube.style.top = `${cubePositionY}px`;
    }

    // --- ORB FUNCTION ---
    function checkOrbCollisions() {
        let touchingAnyOrb = false;
        orbs.forEach(orb => {
            if (isCollidingSimple(cube, orb)) {
                touchingAnyOrb = true;
                currentOrb = orb;
                orb.classList.add('active'); 
            } else {
                orb.classList.remove('active');
            }
        });
        if (!touchingAnyOrb) currentOrb = null;
    }

    function handleKeyDown(event) {
        if (event.key === "ArrowRight") isMovingRight = true;
        if (event.key === "ArrowLeft") isMovingLeft = true;

        if (event.key === "ArrowUp") {
            if (currentOrb) {
                velocityY = orbJumpVelocity; 
                isJumping = true;
                isOnGround = false;
                isOnObstacle = false;
                currentOrb.classList.remove('active'); 
            } 
            else if ((isOnGround || isOnObstacle) && !isJumping) {
                isJumping = true;
                isOnGround = false;
                isOnObstacle = false;
                velocityY = jumpVelocity;
            }
        }

        if (!intervalId) intervalId = setInterval(updateCubePosition, 16);
    }

    function handleKeyUp(event) {
        if (event.key === "ArrowRight") isMovingRight = false;
        if (event.key === "ArrowLeft") isMovingLeft = false;

        if (!isMovingRight && !isMovingLeft && isOnGround && velocityX === 0) {
            clearInterval(intervalId);
            intervalId = null;
        }
    }
    
    // --- COLLISION HELPERS ---
    function isCollidingSimple(a, b) {
        const r1 = a.getBoundingClientRect();
        const r2 = b.getBoundingClientRect();
        return !(r1.bottom < r2.top || r1.top > r2.bottom || r1.right < r2.left || r1.left > r2.right);
    }

    function isCollidingTop(cube, obstacle) {
        const cubeRect = cube.getBoundingClientRect();
        const obstacleRect = obstacle.getBoundingClientRect();
        return (
            cubeRect.bottom <= obstacleRect.top + velocityY + 5 && 
            cubeRect.bottom >= obstacleRect.top &&
            cubeRect.right > obstacleRect.left + 5 &&
            cubeRect.left < obstacleRect.right - 5
        );
    }

    function handleTopCollision(obstacle) {
        // Because of the camera translation, we need to be careful with 'top'
        // But since Y axis isn't scrolling, we can use the visual position
        const obstacleRect = obstacle.getBoundingClientRect();
        // We calculate position relative to the window, but we need to set the style
        // relative to the parent. However, since 'top' is absolute, we just need to match visual.
        
        // Easier method: Use the obstacle's style.top if set, or calculate offset
        // Since obstacles are bottom-aligned usually, let's just snap:
        cubePositionY = window.innerHeight - obstacle.offsetHeight - cubeHeight - 16; 
        
        // Note: If you positioned obstacles using 'top', change calculation above.
        
        velocityY = 0;
        isOnObstacle = true;
        isOnGround = true;
        isJumping = false;
    }

    function isCollidingSides(cube, obstacle) {
        const c = cube.getBoundingClientRect();
        const o = obstacle.getBoundingClientRect();
        return !(c.top > o.bottom || c.bottom < o.top || c.left > o.right || c.right < o.left);
    }

    function handleSideCollision(obstacle) {
        const c = cube.getBoundingClientRect();
        const o = obstacle.getBoundingClientRect();
        
        // Since we are scrolling, getting precise coordinates is tricky with getBoundingClientRect
        // simple stop logic:
        if (velocityX > 0) velocityX = 0; 
        if (velocityX < 0) velocityX = 0;
    }

    window.addEventListener('keydown', handleKeyDown);
    window.addEventListener('keyup', handleKeyUp);
});