function findFactorialRecursive(number) {

    console.log(number)

    if (number === 2)
        return 2;
    else
        return number * findFactorialRecursive(number -1 );
}

function findFactorialIterative(number) {
    let result = 1;

    for (let index = 2; index <= number; index++) {
        result = result * index;
        
    }

    return result;

}

console.log(findFactorialIterative(5));
console.log(findFactorialRecursive(5));