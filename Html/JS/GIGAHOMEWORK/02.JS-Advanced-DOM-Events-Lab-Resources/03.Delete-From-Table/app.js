function deleteByEmail() {
    let email = document.querySelector('input[name="email"]').value;
    let result = document.getElementById("result");
    let rows = Array.from(document.querySelectorAll("tbody tr"));
    let found = false;

    for (const row of rows) {
        if (row.children[1].textContent === email) {
            row.remove();
            found = true;
            result.textContent = "Deleted.";
            break;
        }
    }

    if (!found) {
        result.textContent = "Not found.";
    }
}