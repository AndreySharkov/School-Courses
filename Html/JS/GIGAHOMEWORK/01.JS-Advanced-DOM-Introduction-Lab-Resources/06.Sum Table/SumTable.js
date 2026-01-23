function sumTable() {
    const rows = document.querySelectorAll('table tr');
    let sum = 0;
    for (let i = 1; i < rows.length - 1; i++) {
        const cost = rows[i].lastElementChild.textContent;
        sum += Number(cost);
    }
    document.getElementById('sum').textContent = sum;
}