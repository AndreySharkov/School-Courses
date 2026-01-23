function generateReport() {
    const output = document.getElementById('output');
    const checkboxes = document.querySelectorAll('thead th input');
    const rows = document.querySelectorAll('tbody tr');
    const report = [];

    const selectedCols = Array.from(checkboxes)
        .map((cb, i) => ({ cb, i }))
        .filter(x => x.cb.checked);

    for (const row of rows) {
        const rowData = {};
        const cells = row.querySelectorAll('td');
        for (const col of selectedCols) {
            rowData[col.cb.name] = cells[col.i].textContent;
        }
        report.push(rowData);
    }

    output.value = JSON.stringify(report, null, 2);
}