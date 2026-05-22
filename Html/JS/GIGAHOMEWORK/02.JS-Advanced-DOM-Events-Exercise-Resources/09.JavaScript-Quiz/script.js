function solve() {
    const correctAnswers = ['onclick', 'JSON.stringify()', 'A programming API for HTML and XML documents'];
    const sections = document.querySelectorAll('section');
    const results = document.getElementById('results');
    let rightAnswers = 0;
    let questionIndex = 0;

    document.getElementById('quizzie').addEventListener('click', function(e) {
        if (e.target.classList.contains('answer-text')) {
            const answerText = e.target.textContent;

            if (correctAnswers.includes(answerText)) {
                rightAnswers++;
            }

            sections[questionIndex].classList.add('hidden');
            questionIndex++;

            if (questionIndex < sections.length) {
                sections[questionIndex].classList.remove('hidden');
            } else {
                results.style.display = 'block';
                const h1 = results.querySelector('h1');
                if (rightAnswers === 3) {
                    h1.textContent = 'You are recognized as top JavaScript fan!';
                } else {
                    h1.textContent = `You have ${rightAnswers} right answers`;
                }
            }
        }
    });
}