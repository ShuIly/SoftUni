function checkIfPrime(num) {
    if (num < 2) return false;

    let squareRootNum = Math.sqrt(num);
    for (let i = 2; i < squareRootNum; ++i) {
        if (num % i === 0) {
            return false;
        }
    }

    return true;
}