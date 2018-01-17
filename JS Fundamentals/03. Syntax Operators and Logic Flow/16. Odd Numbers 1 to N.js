function getOddNumbersToN(n) {
    let result = '';
    for (let i = 1; i <= n; i += 2) {
        result += i + '\n';
    }

    return result;
}
