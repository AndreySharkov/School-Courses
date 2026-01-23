function solve(input) {
    let username = input.shift();

    for (const line of input) {
        if (line === 'Registration') {
            break;
        }

        const [command, ...args] = line.split(' ');

        if (command === 'Letters') {
            const caseType = args[0];
            if (caseType === 'Lower') {
                username = username.toLowerCase();
            } else if (caseType === 'Upper') {
                username = username.toUpperCase();
            }
            console.log(username);
        } else if (command === 'Reverse') {
            const startIndex = parseInt(args[0]);
            const endIndex = parseInt(args[1]);

            if (startIndex >= 0 && startIndex < username.length && endIndex >= 0 && endIndex < username.length && startIndex <= endIndex) {
                const sub = username.substring(startIndex, endIndex + 1);
                const reversedSub = sub.split('').reverse().join('');
                username = username.substring(0, startIndex) + reversedSub + username.substring(endIndex + 1, username.length)
                console.log(username);
                
            }
        } else if (command === 'Substring') {
            const sub = args[0];
            if (username.includes(sub)) {
                username = username.replace(sub, '');
                console.log(username);
            } else {
                console.log(`The username ${username} doesn't contain ${sub}.`);
            }
        } else if (command === 'Replace') {
            const char = args[0];
            while (username.includes(char)) {
                username = username.replace(char, '-');
            }
            console.log(username);
        }
    }
}

// Example 1
solve([
    "JohnDoe",
    "Letters Lower",
    "Reverse 1 3",
    "Substring o",
    "Replace n",
    "Registration",
]);

console.log('---');

// Example 2
solve([
    "SuperUser",
    "Letters Upper",
    "Substring per",
    "Reverse 0 4",
    "Replace U",
    "Registration"
]);
