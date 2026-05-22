



export function findNumber(arr){
    let sumNum = 0;
    let BigNum = 0;
    for(let i = 0; i < arr.length; i++){
        let currentSum = 0;
        let numString = arr[i].toString()
        for(let j = 0; j < numString.length; j++) {
            if(Number(numString[j]) % 2 == 0){
                currentSum++
            }
            
        }
        if(currentSum > sumNum){
            sumNum = currentSum;
            BigNum = arr[i]
        }
    }
    return BigNum;
}

