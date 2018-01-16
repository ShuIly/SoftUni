function countLetterOccurrences(str, letter) {
    let letterCount = 0;
    for (let char of str) {
        if (char === letter) {
            letterCount++;
        }
    }

    console.log(letterCount);
}
