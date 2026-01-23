let currentQuestion = 0;
let score = 0;
let userAnswers = Array(quiz.quizItems.length).fill(null);

function showQuizItem(index) {
    const quizItem = document.getElementById('quizItem');
    const quizData = quiz.quizItems[index];
    
    // Show progress
    const progress = `<div class="progress">Въпрос ${index + 1} от ${quiz.quizItems.length}</div>`;
    
    // Show question
    const questionHTML = `<div class="question">${quizData.question}</div>`;
    
    // Show options
    let optionsHTML = '<div class="options">';
    quizData.options.forEach((option, i) => {
        const isChecked = userAnswers[index] === i ? 'checked' : '';
        optionsHTML += `
            <label class="option">
                <input type="radio" name="answer" value="${i}" ${isChecked}>
                ${option}
            </label>
        `;
    });
    optionsHTML += '</div>';
    
    quizItem.innerHTML = progress + questionHTML + optionsHTML;
    
    // Update button states
    document.getElementById('prevBtn').disabled = index === 0;
    document.getElementById('nextBtn').disabled = index === quiz.quizItems.length - 1;
    
    // Clear result display
    document.getElementById('quizResult').style.display = 'none';
}

function checkAnswer() {
    const selectedOption = document.querySelector('input[name="answer"]:checked');
    if (!selectedOption) {
        alert('Моля, изберете отговор!');
        return;
    }
    
    const answer = parseInt(selectedOption.value);
    userAnswers[currentQuestion] = answer;
    
    const quizData = quiz.quizItems[currentQuestion];
    const resultDiv = document.getElementById('quizResult');
    
    if (answer === quizData.correctAnswer) {
        score++;
        resultDiv.textContent = 'Правилен отговор! ✅';
        resultDiv.className = 'correct';
    } else {
        resultDiv.textContent = `Грешен отговор! ❌ Правилният отговор е: ${quizData.options[quizData.correctAnswer]}`;
        resultDiv.className = 'incorrect';
    }
    
    resultDiv.style.display = 'block';
}

function navigate(direction) {
    if (direction === 'next' && currentQuestion < quiz.quizItems.length - 1) {
        currentQuestion++;
    } else if (direction === 'prev' && currentQuestion > 0) {
        currentQuestion--;
    }
    showQuizItem(currentQuestion);
}

// Initialize the quiz
document.addEventListener('DOMContentLoaded', () => {
    showQuizItem(currentQuestion);
    
    document.getElementById('prevBtn').addEventListener('click', () => navigate('prev'));
    document.getElementById('nextBtn').addEventListener('click', () => navigate('next'));
    document.getElementById('checkBtn').addEventListener('click', checkAnswer);
});