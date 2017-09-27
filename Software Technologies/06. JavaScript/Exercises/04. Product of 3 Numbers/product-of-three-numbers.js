function positiveOrNegative(nums) {
    let numArr = nums.map(Number);
    let negCnt = 0;
    for (let i = 0; i < numArr.length; ++i) {
        if (numArr[i] === 0) {
            return 'Positive';
        } else if (numArr[i] < 0) {
            negCnt++;
        }
    }
    if (negCnt % 2 === 0) {
        return 'Positive';
    } else {
        return 'Negative';
    }
}