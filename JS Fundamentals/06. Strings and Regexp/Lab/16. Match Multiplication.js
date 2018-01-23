function multiplyMatches(str) {
    let regex = /(-?\d+(?:\.\d+)?)\s*\*\s*(-?\d+(?:\.\d+)?)/;
    let match;
    while ((match = regex.exec(str)) !== null) {
        let multiplied = Number(match[1]) * Number(match[2]);
        str = str.replace(match[0], multiplied);
    }

    return str;
}