function orbit([height, width, x, y]) {
    let matrix = [];
    for (let i = 0; i < height; i++) {
        matrix.push(new Array(width));
    }

    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            matrix[i][j] = Math.max(Math.abs(i - x), Math.abs(j - y)) + 1;
        }
    }

    let result = '';
    for (let arr of matrix) {
        result += arr.join(' ') + '\n';
    }

    return result;
}