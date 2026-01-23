function addItem() {
    let textbox = document.getElementById("newItemText");
    let list = document.getElementById("items");

    let li = document.createElement("li");
    li.textContent = textbox.value;

    let a = document.createElement("a");
    a.textContent = '[Delete]';
    a.setAttribute('href', '#');
    
    a.addEventListener("click", (ev) => {
        ev.target.parentElement.remove();
    });

    li.appendChild(a);
    list.appendChild(li);
    
    textbox.value = "";
}