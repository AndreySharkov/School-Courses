function cookiBookie(days){
    let twoCociesSugar = 2.5
    let waffleSugar = 9
    let cupcakeSugar = 15
    let totalSugar = 0;
    for(let i = 0; i < days; i++){
        totalSugar += twoCociesSugar;
        totalSugar += waffleSugar;
        if(days % 5 == 0){
            totalSugar += cupcakeSugar;
        }

    }
    console.log(`You have consumed ${totalSugar} grams of sugar`)

}

cookiBookie(1)