function diagonalAttack(strArr) {
    let numMatrix = [];
    let boolMatrix = [];

    for (let arr of strArr) {
        numMatrix.push(arr.split(' ').map(Number));
        boolMatrix.push(new Array(numMatrix[0].length).fill(false));
    }

    let leftDiagSum = 0;
    for (let i = 0, j = 0; i < numMatrix.length; ++i, ++j) {
        leftDiagSum += numMatrix[i][j];
        boolMatrix[i][j] = true;
    }

    let rightDiagSum = 0;
    for (let i = 0, j = numMatrix[0].length - 1; i < numMatrix.length; ++i, --j) {
        rightDiagSum += numMatrix[i][j];
        boolMatrix[i][j] = true;
    }

    let result = ' ';
    if (leftDiagSum === rightDiagSum) {
        for (let i = 0; i < numMatrix.length; ++i) {
            for (let j = 0; j < numMatrix[i].length; ++j) {
                if (boolMatrix[i][j] === false) {
                    numMatrix[i][j] = leftDiagSum;
                }
            }

            result += numMatrix[i].join(' ') + '\n';
        }
    } else {
        for (let arr of numMatrix) {
            result += arr.join(' ') + '\n';
        }
    }

    return result;
}
