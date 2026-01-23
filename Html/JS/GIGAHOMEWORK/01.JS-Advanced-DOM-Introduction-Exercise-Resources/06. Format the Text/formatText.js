function solve() {
  const input = document.getElementById('input');
  const output = document.getElementById('output');

  const sentences = input.value.split('.').filter(s => s.trim().length > 0);

  output.innerHTML = '';

  for (let i = 0; i < sentences.length; i += 3) {
    const p = document.createElement('p');
    const pSentences = sentences.slice(i, i + 3).map(s => s.trim());
    p.textContent = pSentences.join('. ') + '.';
    output.appendChild(p);
  }
}