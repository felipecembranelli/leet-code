const prompt = require("prompt-sync")();

function fibonacciRecursive(n) {
    // 0,1,1,2,3,5,8,13,21,34...

    if (n < 2) {
        return n;
    }

    return fibonacciRecursive(n - 1) + fibonacciRecursive(n -2);       
}

function generateFibonacci(n) {
    if (n < 2) {
        return n;
    }

    return console.log(generateFibonacci(n - 1) + generateFibonacci(n -2));

}

//generateFibonacci(3);
//console.log(fibonacciRecursive(4));

// take nth term input from the user
const nTerms = prompt('Enter the number of terms: ');

if(nTerms <=0) {
    console.log('Enter a positive integer.');
}
else {
    for(let i = 0; i < nTerms; i++) {
        console.log(fibonacciRecursive(i));
    }
}