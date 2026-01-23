function extract(content) {
    const text = document.getElementById(content).textContent;
    const regex = /\(([^)]+)\)/g;
    const matches = text.matchAll(regex);
    const result = Array.from(matches).map(match => match[1]).join('; ');
    return result;
}