function isMatrixMagical(matrix) {
    matrix[0] = matrix[0].map(Number);

    let magicSum = matrix[0].reduce((a, b) => a + b);
    for (let i = 1; i < matrix.length; ++i) {
        matrix[i] = matrix[i].map(Number);
        if (matrix[i].reduce((a, b) => a + b) !== magicSum) {
            return false;
        }
    }

    for (let i = 0; i < matrix[0].length; ++i) {
        let currSum = 0;
        for (let j = 0; j < matrix.length; ++j) {
            currSum += matrix[j][i];
        }

        if (currSum !== magicSum) {
            return false;
        }
    }

    return true;
}
