function solve() {
    const selectMenuTo = document.getElementById('selectMenuTo');
    const resultInput = document.getElementById('result');
    const numberInput = document.getElementById('input');
    const convertBtn = document.querySelector('button');

    const binaryOption = document.createElement('option');
    binaryOption.value = 'binary';
    binaryOption.textContent = 'Binary';
    selectMenuTo.appendChild(binaryOption);

    const hexadecimalOption = document.createElement('option');
    hexadecimalOption.value = 'hexadecimal';
    hexadecimalOption.textContent = 'Hexadecimal';
    selectMenuTo.appendChild(hexadecimalOption);

    selectMenuTo.options[0].remove();

    convertBtn.addEventListener('click', () => {
        const number = Number(numberInput.value);
        const convertTo = selectMenuTo.value;
        let result;
        if (convertTo === 'binary') {
            result = number.toString(2);
        } else if (convertTo === 'hexadecimal') {
            result = number.toString(16).toUpperCase();
        }
        resultInput.value = result;
    });
}