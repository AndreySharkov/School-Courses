function solve() {
  const text = document.getElementById('text').value;
  const convention = document.getElementById('naming-convention').value;
  const resultElement = document.getElementById('result');

  const words = text.toLowerCase().split(' ').filter(w => w !== '');
  let result = '';

  if (convention === 'Pascal Case') {
    result = words.map(w => w.charAt(0).toUpperCase() + w.slice(1)).join('');
  } else if (convention === 'Camel Case') {
    const pascal = words.map(w => w.charAt(0).toUpperCase() + w.slice(1)).join('');
    result = pascal.charAt(0).toLowerCase() + pascal.slice(1);
  } else {
    result = 'Error!';
  }

  resultElement.textContent = result;
}