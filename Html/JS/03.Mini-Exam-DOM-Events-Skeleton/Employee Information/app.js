function deleteByID() {
    let textbox = document.getElementsByTagName("input")
    let employees = [...document.getElementsByTagName("td")]
    let result = document.getElementById("result")
    employees.forEach(em => {
        if(em.textContent == textbox[0].value){
            em.parentElement.remove();
            result.textContent = 'Deleted.'

        }
    });
}