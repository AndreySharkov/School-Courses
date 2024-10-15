document.addEventListener('DOMContentLoaded', () => {
    const cube = document.querySelector('.cube');
    const obstacles = document.querySelectorAll('.obstacle'); 
    const box1 = document.querySelector('.box1');
    const box2 = document.querySelector('.box2');

    const maxSpeed = 10;   
    const acceleration = 1; 
    const friction = 0.05; 
    const gravity = 2;   
    const jumpVelocity = -32; 
    let cubePositionX = 0;   
    let cubePositionY = 0;   
    let velocityX = 0;       
    let velocityY = 0;      
    let isJumping = false;   
    let isOnGround = true;  
    let isOnObstacle = false; 
    let isMovingRight = false;
    let isMovingLeft = false;
    let intervalId = null;

    const cubeHeight = 25;   
    const groundLevel = window.innerHeight - cubeHeight - 16;  
    cubePositionY = groundLevel;

    function updateCubePosition() {
        // Horizontal movement
        if (isMovingRight) {
            velocityX += acceleration;  // Accelerate to the right
        } 
        if (isMovingLeft) {
            velocityX -= acceleration;  // Accelerate to the left
        }
        if (!isMovingRight && !isMovingLeft) {
            if (velocityX > 0) {
                velocityX -= friction;  // Decelerate if moving right
            } else if (velocityX < 0) {
                velocityX += friction;  // Decelerate if moving left
            }

            // Stop the cube completely when velocity is very low
            if (Math.abs(velocityX) < friction) {
                velocityX = 0;
            }
        }

        // Clamp horizontal velocity to maxSpeed
        velocityX = Math.max(-maxSpeed, Math.min(maxSpeed, velocityX));
        cubePositionX += velocityX;

        // Clamp horizontal position within window boundaries
        cubePositionX = Math.max(0, Math.min(window.innerWidth - cube.offsetWidth, cubePositionX));

        if (!isOnGround) {
            velocityY += gravity;  // Apply gravity when not on the ground
            cubePositionY += velocityY;
        }

        // Check if the cube hits the ground
        if (cubePositionY >= groundLevel && !isOnObstacle) {
            cubePositionY = groundLevel;
            velocityY = 0;
            isOnGround = true;  
            isJumping = false;
        }

        // Collision check with both obstacles
        obstacles.forEach(obstacle => {
            if (isCollidingTop(cube, obstacle)) {
                handleTopCollision(obstacle);
            } else if (isCollidingSides(cube, obstacle)) {
                handleSideCollision(obstacle);
            }
        });

        if (isOnObstacle) {
            let isOffObstacle = true;
            obstacles.forEach(obstacle => {
                const obstacleRect = obstacle.getBoundingClientRect();
                if (cubePositionX >= obstacleRect.left && cubePositionX <= obstacleRect.right) {
                    isOffObstacle = false;
                }
            });
            if (isOffObstacle) {
                isOnObstacle = false;
                isOnGround = false; 
            }
        }
        if(isCollidingSides(cube, box1))
        {
        
           window.location.href = 'about.html';
        }
        if (isCollidingSides(cube, box2))
        {
           window.location.href = 'about.html';

        }

        cube.style.left = `${cubePositionX}px`;
        cube.style.top = `${cubePositionY}px`;
    }

    function handleKeyDown(event) {
        if (event.key === "ArrowRight") {
            isMovingRight = true;  // Start moving right
        } 
        if (event.key === "ArrowLeft") {
            isMovingLeft = true;   // Start moving left
        }
        
        

        if ((event.key === "ArrowUp") && (isOnGround || isOnObstacle) && !isJumping) {
            isJumping = true;
            isOnGround = false;
            isOnObstacle = false;  // Reset obstacle hold when jumping
            velocityY = jumpVelocity; // Apply jump velocity

        }
        

        // Start the movement loop if it's not already running
        if (!intervalId) {
            intervalId = setInterval(updateCubePosition, 16); // 16ms for ~60 FPS
        }
    }

    function isCollidingTop(cube, obstacle) {
        const cubeRect = cube.getBoundingClientRect();
        const obstacleRect = obstacle.getBoundingClientRect();

        return (
            cubeRect.bottom <= obstacleRect.top + velocityY && // Detect if the cube is coming down on the obstacle
            cubeRect.bottom >= obstacleRect.top &&
            cubeRect.right > obstacleRect.left &&
            cubeRect.left < obstacleRect.right
        );
    }

    function handleTopCollision(obstacle) {
        const obstacleRect = obstacle.getBoundingClientRect();
        cubePositionY = obstacleRect.top - cubeHeight - 0.5;  // Place the cube on top of the obstacle
        velocityY = 0;  // Stop falling
        isOnObstacle = true;  // Cube is now on the obstacle
        isOnGround = true;    // Treat as ground
        isJumping = false;    // Jump is reset
    }

    function isCollidingSides(cube, obstacle) {
        const cubeRect = cube.getBoundingClientRect();
        const obstacleRect = obstacle.getBoundingClientRect();

        return !(
            cubeRect.top > obstacleRect.bottom ||
            cubeRect.bottom < obstacleRect.top ||
            cubeRect.left > obstacleRect.right ||
            cubeRect.right < obstacleRect.left
        );
    }

    function handleSideCollision(obstacle) {
        const cubeRect = cube.getBoundingClientRect();
        const obstacleRect = obstacle.getBoundingClientRect();

        if (velocityX > 0 && cubeRect.right > obstacleRect.left) {
            cubePositionX = obstacleRect.left - cubeRect.width - 0.5;
            velocityX = 0; // Stop movement to the right
        }

        if (velocityX < 0 && cubeRect.left < obstacleRect.right) {
            cubePositionX = obstacleRect.right + 0.5;
            velocityX = 0; // Stop movement to the left
        }
    }

    function handleKeyUp(event) {
        if (event.key === "ArrowRight") {
            isMovingRight = false; // Stop accelerating to the right
        } 
        if (event.key === "ArrowLeft") {
            isMovingLeft = false;  // Stop accelerating to the left
        }

        // Stop movement if no keys are pressed
        if (!isMovingRight && !isMovingLeft && isOnGround && velocityX === 0) {
            clearInterval(intervalId);
            intervalId = null;
        }
    }

    window.addEventListener('keydown', handleKeyDown);
    window.addEventListener('keyup', handleKeyUp);
});
