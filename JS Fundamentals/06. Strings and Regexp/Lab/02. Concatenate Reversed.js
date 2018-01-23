function concatReversed(strArr) {
    let result = '';
    for (let i = strArr.length - 1; i >= 0; --i) {
        for (let j = strArr[i].length - 1; j >= 0; --j) {
            result += strArr[i][j];
        }
    }

    return result;
}
