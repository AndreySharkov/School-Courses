lettersChangeNumbers('A12b s17G')
lettersChangeNumbers('P34562Z q2576f   H456z')

function lettersChangeNumbers(input) {
    let words = input.split(/\s+/).filter(x => x !== '');
    let alpabets = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz';
    let sum = 0;

    for (let word of words) {
        let firstLetter = word[0];
        let lastLetter = word[word.length - 1];
        let num = Number(word.slice(1, word.length - 1));
        if (alpabets.indexOf(firstLetter) < 26) {
            num = num / (alpabets.indexOf(firstLetter) + 1);
        } else {
            num = num * (alpabets.indexOf(firstLetter) - 25);
        }

        if (alpabets.indexOf(lastLetter) < 26) {
            num = num - (alpabets.indexOf(lastLetter) + 1);
        } else {
            num = num + (alpabets.indexOf(lastLetter) - 25);
        }

        sum += num;
    }
    console.log(sum.toFixed(2));

}