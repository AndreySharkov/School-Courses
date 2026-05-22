function solve() {
  const [generateBtn, buyBtn] = document.querySelectorAll('button');
  const [inputArea, outputArea] = document.querySelectorAll('textarea');
  const tableBody = document.querySelector('tbody');

  generateBtn.addEventListener('click', generate);
  buyBtn.addEventListener('click', buy);

  function generate() {
    const data = JSON.parse(inputArea.value);

    for (const item of data) {
      const row = document.createElement('tr');

      const imgCell = document.createElement('td');
      const img = document.createElement('img');
      img.src = item.img;
      imgCell.appendChild(img);
      row.appendChild(imgCell);

      const nameCell = document.createElement('td');
      const nameP = document.createElement('p');
      nameP.textContent = item.name;
      nameCell.appendChild(nameP);
      row.appendChild(nameCell);

      const priceCell = document.createElement('td');
      const priceP = document.createElement('p');
      priceP.textContent = item.price;
      priceCell.appendChild(priceP);
      row.appendChild(priceCell);

      const decFactorCell = document.createElement('td');
      const decFactorP = document.createElement('p');
      decFactorP.textContent = item.decFactor;
      decFactorCell.appendChild(decFactorP);
      row.appendChild(decFactorCell);

      const markCell = document.createElement('td');
      const markInput = document.createElement('input');
      markInput.type = 'checkbox';
      markCell.appendChild(markInput);
      row.appendChild(markCell);

      tableBody.appendChild(row);
    }
  }

  function buy() {
    const checkedBoxes = document.querySelectorAll('tbody input[type="checkbox"]:checked');
    let names = [];
    let totalPrice = 0;
    let totalDecFactor = 0;

    for (const box of checkedBoxes) {
      const row = box.parentElement.parentElement;
      const name = row.querySelector('td:nth-child(2) p').textContent;
      const price = Number(row.querySelector('td:nth-child(3) p').textContent);
      const decFactor = Number(row.querySelector('td:nth-child(4) p').textContent);

      names.push(name);
      totalPrice += price;
      totalDecFactor += decFactor;
    }

    outputArea.value = `Bought furniture: ${names.join(', ')}\n`;
    outputArea.value += `Total price: ${totalPrice.toFixed(2)}\n`;
    outputArea.value += `Average decoration factor: ${totalDecFactor / names.length}`;
  }
}