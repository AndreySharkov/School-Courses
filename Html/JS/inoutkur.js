function inout(input) {
    let arr = [];
    input.forEach(i => {
        if (i[0] == "IN"){
            arr.push(i[1]);

        }
        else if (i[0] == "OUT"){
            let index = arr.indexOf(i[1]);
            if (index !== -1) {
                arr.splice(index, 1);
            }
        }

        
    });
    arr.forEach(a => {
        console.log(a);
    });

}

