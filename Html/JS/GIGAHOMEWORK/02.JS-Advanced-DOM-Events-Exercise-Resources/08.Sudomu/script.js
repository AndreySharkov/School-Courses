    function solve() {
        const [checkBtn, clearBtn] = document.querySelectorAll('button');
        const table = document.querySelector('table');
        const inputs = document.querySelectorAll('input');
        const checkP = document.querySelector('#check p');

        checkBtn.addEventListener('click', check);
        clearBtn.addEventListener('click', clear);

        function check() {
            const grid = [
                [...inputs].slice(0, 3).map(i => Number(i.value)),
                [...inputs].slice(3, 6).map(i => Number(i.value)),
                [...inputs].slice(6, 9).map(i => Number(i.value))
            ];

            let isSolved = true;

            // Check rows and for empty cells
            for (let i = 0; i < 3; i++) {
                const row = new Set(grid[i]);
                if (row.size !== 3 || grid[i].includes(0)) {
                    isSolved = false;
                    break;
                }
            }

            // Check columns
            if (isSolved) {
                for (let i = 0; i < 3; i++) {
                    const col = new Set([grid[0][i], grid[1][i], grid[2][i]]);
                    if (col.size !== 3) {
                        isSolved = false;
                        break;
                    }
                }
            }

            if (isSolved) {
                table.style.border = '2px solid green';
                checkP.textContent = 'You solve it! Congratulations!';
                checkP.style.color = 'green';
            } else {
                table.style.border = '2px solid red';
                checkP.textContent = 'NOP! You are not done yet...';
                checkP.style.color = 'red';
            }
        }

        function clear() {
            [...inputs].forEach(i => i.value = '');
            table.style.border = '';
            checkP.textContent = '';
        }
    }