function getBiggestElement(matrix) {
    let maxElement = matrix[0][0];
    for (let arr of matrix) {
        let arrMaxNum = Math.max(...arr);
        if (arrMaxNum > maxElement) {
            maxElement = arrMaxNum;
        }
    }

    return maxElement;
}