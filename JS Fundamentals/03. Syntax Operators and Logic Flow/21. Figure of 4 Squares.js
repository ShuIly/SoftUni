function getFigureOfSquares(n) {
    let dashes = '-'.repeat(n - 2);
    let whitespaces = ' '.repeat(n - 2);

    let result = '';
    let middlePartsCount = Math.floor((n - 3) / 2);

    for (let count = 0; count < 2; ++count) {
        result += `+${dashes}+${dashes}+\n`;
        for (let i = 0; i < middlePartsCount; ++i) {
            result += `|${whitespaces}|${whitespaces}|\n`;
        }
    }
    result += `+${dashes}+${dashes}+\n`;

    return result;
}

