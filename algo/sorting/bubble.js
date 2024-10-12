function sort(values) {

    let counter=0;

    for (let j = 0; j < values.length -1; j++) {

        for (let index = 0; index < values.length -1; index++) {
            const element1 = values[index];
            const element2 = values[index + 1];
    
            if (element1 > element2) {
                values[index + 1] = element1;
                values[index] = element2
            }
            console.log(counter++)
        }
        console.log(values);
    }   
}

sort([2,3,7,1,49,38,10,50,100,90,78,67,66]);