function getDiagonalSums(matrix) {
    let leftDiagonalSum = 0;
    for (let i = 0, j = matrix.length - 1; i < matrix.length; ++i, --j) {
        leftDiagonalSum += matrix[i][j];
    }

    let rightDiagonalSum = 0;
    for (let i = 0, j = 0; i < matrix.length; ++i, ++j) {
        rightDiagonalSum += matrix[i][j];
    }

    console.log(rightDiagonalSum + ' ' + leftDiagonalSum);
}