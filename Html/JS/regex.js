
function winningTicket(ticket) {
    let result = '';
    let regex = /[&]{6,10}|[*]{6,10}|[%]{6,10}|[#]{6,10}/g;

    let match = ticket.match(regex);
    if (ticket.nlegth === 20) {
        if (match) {
            let symbol = match[0][0];
            let length = match[0].length;

            if (length >= 6 && length <= 9) {
                console.log('Card has won a Line');
                console.log(`ticket "${ticket}" - ${length}${symbol}`);
                console.log(`symbols: ${symbol}`);

            } else if (length === 10) {
                
                console.log(`Bingo! "${ticket}" - ${length}`);
                console.log(`symbols: ${symbol}`);
            }
        } 
        else {
            console.log(`Card "${ticket}" - doesn't win`);    
        }
    } 
    else {
        console.log('invalid Bingo Card');
    }

    

}

winningTicket('Bing&&&&&&Oo&&&&&&ye')

winningTicket('&&&&&&&&&&&&&&&&&&&&')


winningTicket('skdhagsdncpotwnufmla')