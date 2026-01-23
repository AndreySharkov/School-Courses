function addItem() {
    let textbox = document.getElementById("newItemText")
    let list = document.getElementById("items")
    let li = document.createElement("li")
    let a = document.createElement("a")
    a.textContent = '[Delete]'
    a.setAttribute('href, "#')
    a.addEventListener("click", (ev) => {
        console.log(ev)
    })

    li.textContent = textbox.value
    ul.appendChild(li)
    textbox.value = ""
}