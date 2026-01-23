function solution() {
    let inp = document.querySelector('input')
    let rBtn = document.getElementById("registerButton")
    let ulParcel = document.getElementsByTagName("ul")[0]
    let ulSent = document.getElementsByTagName("ul")[1]

    rBtn.addEventListener('click', (e) => {
        let li = document.createElement("li")
        li.textContent = inp.value
        
        let sBtn = document.createElement("button")
        sBtn.textContent = "Send"
        li.appendChild(sBtn)
        ulParcel.appendChild(li)
        
        Array.from(ulParcel.getElementsByTagName("li"))
            .sort((a,b) => a.textContent.localeCompare(b.textContent))
            .forEach(li => ulParcel.appendChild(li))
        

        sBtn.addEventListener('click', (s) => {
            li.removeChild(sBtn)
            let sli = document.createElement("li")
            sli.textContent = li.textContent
            ulSent.appendChild(sli)
            li.remove()
            Array.from(ulSent.getElementsByTagName("li"))
            .sort((a,b) => a.textContent.localeCompare(b.textContent))
            .forEach(li => ulSent.appendChild(li))
        })
    })
}