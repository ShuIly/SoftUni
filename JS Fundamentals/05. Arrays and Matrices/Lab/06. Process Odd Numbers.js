function printOddNums(arr) {
    let oddReversedArr = [];
    for (let i = 1; i < arr.length; i += 2) {
        oddReversedArr.push(arr[i] * 2);
    }

    return oddReversedArr.reverse().join(' ');
}
