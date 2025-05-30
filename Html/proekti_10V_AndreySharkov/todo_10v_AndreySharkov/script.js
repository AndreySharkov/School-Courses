document.addEventListener("DOMContentLoaded", () => {
    let addButton = document.getElementById('add');
    let taskList = document.getElementById('tasks');
    let textBox = document.getElementById('textBox');

    addButton.addEventListener("click", () => {
        const taskText = textBox.value.trim();
        if(taskText !== ""){
            addTask(taskText);
            textBox.value = "";
            textBox.focus();
        }
    });

    textBox.addEventListener("keypress", (e) => {
        if(e.key === "Enter") {
            const taskText = textBox.value.trim();
            if(taskText !== ""){
                addTask(taskText);
                textBox.value = "";
            }
        }
    });

    function addTask(taskText, isCompleted = false) {
        const taskItem = document.createElement("li");
        taskItem.className = "task-Item";
        
        const checkBox = document.createElement("input");
        checkBox.type = "checkbox";
        checkBox.checked = isCompleted;
        if(isCompleted) {
            taskItem.classList.add("completed");
        }
        
        checkBox.addEventListener("change", () => {
            taskItem.classList.toggle("completed");
        });
        
        const taskSpan = document.createElement("span");
        taskSpan.textContent = taskText;
        
        const deleteButton = document.createElement("button");
        deleteButton.textContent = "Delete";
        deleteButton.className = "delete-button";
        deleteButton.addEventListener("click", () => {
            taskItem.classList.add("fade-out");
            setTimeout(() => {
                taskItem.remove();
                checkEmptyState();
            }, 300);
        });
        
        taskItem.appendChild(checkBox);
        taskItem.appendChild(taskSpan);
        taskItem.appendChild(deleteButton);
        
        taskItem.style.opacity = "0";
        taskItem.style.transform = "translateX(-20px)";
        taskList.appendChild(taskItem);
        
        setTimeout(() => {
            taskItem.style.opacity = "1";
            taskItem.style.transform = "translateX(0)";
            taskItem.style.transition = "all 0.3s ease";
        }, 10);
        
        checkEmptyState();
    }
    
    function checkEmptyState() {
        const emptyState = document.querySelector(".empty-state");
        if(taskList.children.length === 0) {
            if(!emptyState) {
                const emptyMsg = document.createElement("div");
                emptyMsg.className = "empty-state";
                emptyMsg.textContent = "Your todo list is empty. Add some tasks!";
                taskList.appendChild(emptyMsg);
            }
        } else if(emptyState) {
            emptyState.remove();
        }
    }
    
    checkEmptyState();
});