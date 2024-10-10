document.addEventListener('DOMContentLoaded', () => {
    const cube = document.querySelector('.cube');
    const maxSpeed = 10;   // Maximum speed
    const acceleration = 0.5; // Rate of acceleration
    const friction = 0.05; // Rate of deceleration (friction effect)
    let cubePosition = 0;
    let velocity = 0;      // Current velocity
    let isMovingRight = false;
    let isMovingLeft = false;
    let intervalId = null;
    let height = 50;
   
    // Function to update cube position with velocity
    function updateCubePosition() {
        if (isMovingRight) {
            velocity += acceleration;  // Accelerate to the right
        } 
        if (isMovingLeft) {
            velocity -= acceleration;  // Accelerate to the left
        }
        if (!isMovingRight && !isMovingLeft) {
            if (velocity > 0) {
                velocity -= friction;  // Decelerate if moving right
            } else if (velocity < 0) {
                velocity += friction;  // Decelerate if moving left
            }

            // Stop the cube completely when velocity is very low
            if (Math.abs(velocity) < friction) {
                velocity = 0;
            }
        }
       

        
        velocity = Math.max(-maxSpeed, Math.min(maxSpeed, velocity));
        cubePosition += velocity;
        cubePosition = Math.max(0, Math.min(window.innerWidth - cube.offsetWidth, cubePosition));
        cube.style.left = `${cubePosition}px`;
        cube.style.height += height + 'px';
    }

    // Function to handle keydown events
    function handleKeyDown(event) {
        if (event.key === "ArrowRight") {
            isMovingRight = true;  // Start moving right
        } 
        if (event.key === "ArrowLeft") {
            isMovingLeft = true;   // Start moving left
        }
        if(event.key === " "){
            height = 60;
        }

        // Start the movement loop if it's not already running
        if (!intervalId) {
            intervalId = setInterval(updateCubePosition, 16); // 16ms for ~60 FPS
        }
    }

    // Function to handle keyup events
    function handleKeyUp(event) {
        if (event.key === "ArrowRight") {
            isMovingRight = false; // Stop accelerating to the right
        } 
        if (event.key === "ArrowLeft") {
            isMovingLeft = false;  // Stop accelerating to the left
        }
        height = 50;
        

        // Let the interval continue to apply friction and stop movement naturally
    }
    

    
    window.addEventListener('keydown', handleKeyDown);
    window.addEventListener('keyup', handleKeyUp);
});
