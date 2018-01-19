function getSmallestTwoNums(arr) {
    return arr.map(Number).sort((a, b) => a - b).slice(0, 2).join(' ');
}