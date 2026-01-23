function extractText() {
    const listItems = document.getElementById('items').children;
    const result = document.getElementById('result');
    const itemsText = Array.from(listItems).map(li => li.textContent).join('\n');
    result.value = itemsText;
}