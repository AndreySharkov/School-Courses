function solve(input) {
    const movies = {};
    const n = parseInt(input.shift());

    for (let i = 0; i < n; i++) {
        const [movieTitle, budget] = input.shift().split(':::');
        movies[movieTitle] = { budget: Number(budget), score: 0, scores: [] };
    }

    for (const line of input) {
        if (line === 'EndFestival') {
            break;
        }

        const parts = line.split(' => ');
        const command = parts[0];
        const details = parts[1];

        if (command === 'Score') {
            const [movieTitle, points] = details.split(' | ');
            if (movies[movieTitle]) {
                movies[movieTitle].scores.push(Number(points));
                const totalScore = movies[movieTitle].scores.reduce((a, b) => a + b, 0);
                movies[movieTitle].score = totalScore / movies[movieTitle].scores.length;
            }
        } else if (command === 'Revise') {
            const [movieTitle, newBudget] = details.split(' | ');
            if (movies[movieTitle]) {
                movies[movieTitle].budget = Number(newBudget);
            }
        } else if (command === 'Clear') {
            const movieTitle = details;
            if (movies[movieTitle]) {
                movies[movieTitle].score = 0;
                movies[movieTitle].scores = [];
            }
        }
    }

    console.log("Movies for the festival:");
    Object.entries(movies).forEach(([title, data]) => {
        console.log(`- ${title}; Budget: ${data.budget}; Score: ${data.score.toFixed(2)}`);
    });
}

// Example 1
solve([
    "3",
    "Inception:::160",
    "Arrival:::47",
    "Gravity:::100",
    "Score => Inception | 8",
    "Score => Gravity | 9",
    "Revise => Arrival | 55",
    "Clear => Gravity",
    "EndFestival"
]);

console.log('---');

// Example 2
solve([
    "2",
    "Inception:::160",
    "Arrival:::47",
    "Score => Arrival | 7",
    "Score => Inception | 6",
    "EndFestival"
]);
