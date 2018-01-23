function countOccurrences(word, str) {
    let count = 0;
    let index = -1;
    while ((index = str.indexOf(word, index + 1)) !== -1) {
        count++;
    }

    return count;
}
