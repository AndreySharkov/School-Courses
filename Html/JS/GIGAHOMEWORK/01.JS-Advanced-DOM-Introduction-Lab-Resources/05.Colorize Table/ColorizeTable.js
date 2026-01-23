function colorize() {
    const rows = document.querySelectorAll('tr:nth-child(even)');
    Array.from(rows).forEach(row => {
        row.style.backgroundColor = 'Teal';
    });
}