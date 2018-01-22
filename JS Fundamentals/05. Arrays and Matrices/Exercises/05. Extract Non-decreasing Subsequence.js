function getIncSequence(arr) {
    arr = arr.map(Number);

    let nonDecArr = [];
    let currMaxNum = Number.NEGATIVE_INFINITY;
    for (let i = 0; i < arr.length; ++i) {
        if (arr[i] >= currMaxNum) {
            nonDecArr.push(arr[i]);
            currMaxNum = arr[i];
        }
    }

    return nonDecArr.join('\n');
}