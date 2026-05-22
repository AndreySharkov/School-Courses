function addItem() {
    let textbox = document.getElementById("newItemText");
    let list = document.getElementById("items");

    let li = document.createElement("li");
    li.textContent = textbox.value;

    list.appendChild(li);
    
    textbox.value = "";
}