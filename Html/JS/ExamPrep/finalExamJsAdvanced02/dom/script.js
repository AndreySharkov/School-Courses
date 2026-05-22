function solve() {
    const nameBox = document.getElementById("name");
    const emailBox = document.getElementById("email");
    const ticketSelect = document.getElementById("ticket");
    const registerBtn = document.getElementById("registerBtn");
    const vipList = document.getElementById("vipList");
    const standardList = document.getElementById("standardList");

    registerBtn.addEventListener("click", (ev) => {
        ev.preventDefault();

        const name = nameBox.value.trim();
        const email = emailBox.value.trim();
        const ticketType = ticketSelect.value;

        if (name === "" || email === "") {
            return;
        }

        const li = document.createElement("li");
        li.textContent = `${name} (${email}) `;

        const removeBtn = document.createElement("button");
        removeBtn.className = "remove";
        removeBtn.textContent = "Remove";
        
        li.appendChild(removeBtn);

        if (ticketType === "VIP") {
            vipList.appendChild(li);
        } else {
            standardList.appendChild(li);
        }

        nameBox.value = "";
        emailBox.value = "";
    });

    document.addEventListener("click", (ev) => {
        if (ev.target.classList.contains("remove")) {
            ev.target.parentElement.remove();
        }
    });
}

window.addEventListener('load', solve);
