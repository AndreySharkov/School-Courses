revealWords('great','softuni is ***** place for learning new programming languages')
revealWords('great, learning','softuni is ***** place for ******** new programming languages')

function revealWords(input) {
    let arr = input.split(',');
    let txt = arr[arr.leth - 1];
    for (let i = 0; i < arr.length - 1; i++) {
        let word = arr[i];
        let stars = '*'.repeat(word.length);
        txt = txt.replace(stars, word);
    }
    console.log(txt)
    

}