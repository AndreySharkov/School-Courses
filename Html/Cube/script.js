document.addEventListener('DOMContentLoaded', () => {
    const cube = document.querySelector('.cube');
    const obstacle = document.querySelector('.obstacle');
    const maxSpeed = 10;   // Maximum speed for left/right movement
    const acceleration = 1; // Rate of acceleration
    const friction = 0.05; // Rate of deceleration (friction effect)
    const gravity = 2;   // Gravity pulling the cube down
    const jumpVelocity = -32; // Initial velocity for jumping
    let cubePositionX = 0;   // Horizontal position
    let cubePositionY = 0;   // Vertical position (0 is the ground level)
    let velocityX = 0;       // Current horizontal velocity
    let velocityY = 0;       // Current vertical velocity (for jumping)
    let isJumping = false;   // Flag to track if the cube is jumping
    let isOnGround = true;   // Flag to track if the cube is on the ground
    let isMovingRight = false;
    let isMovingLeft = false;
    let intervalId = null;

    const cubeHeight = 50;   // Cube's height (adjust to match the actual size)
    const groundLevel = window.innerHeight - cubeHeight;  // Set ground level
    cubePositionY = groundLevel;

    // Function to update cube position with velocity and gravity
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

        // Vertical movement (gravity and jumping)
        if (!isOnGround) {
            velocityY += gravity;  // Apply gravity when not on the ground
            cubePositionY += velocityY;
        }

        // Check if the cube hits the ground
        if (cubePositionY >= groundLevel ) {
            cubePositionY = groundLevel;
            velocityY = 0;
            isOnGround = true;  // Cube is back on the ground
            isJumping = false;
        }

        // Apply the positions to the cube
        cube.style.left = `${cubePositionX}px`;
        cube.style.top = `${cubePositionY}px`;
    }

    // Function to handle keydown events
    function handleKeyDown(event) {
        if (event.key === "ArrowRight") {
            isMovingRight = true;  // Start moving right
        } 
        if (event.key === "ArrowLeft") {
            isMovingLeft = true;   // Start moving left
        }

        if (event.key === " " || event.key === "ArrowUp" && isOnGround && !isJumping) {
            isJumping = true;
            isOnGround = false;
            velocityY = jumpVelocity; // Apply jump velocity
        }

        // Start the movement loop if it's not already running
        if (!intervalId) {
            intervalId = setInterval(updateCubePosition, 16); // 16ms for ~60 FPS
        }
    }
    function isColliding(cube, obstacle) {
        const cubeRect = cube.getBoundingClientRect();
        const obstacleRect = obstacle.getBoundingClientRect();

        return !(
            cubeRect.top > obstacleRect.bottom ||
            cubeRect.bottom < obstacleRect.top ||
            cubeRect.left > obstacleRect.right ||
            cubeRect.right < obstacleRect.left
        );
    }
    // Function to handle keyup events
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
