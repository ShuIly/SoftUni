function countWords([str]) {
    let words = str.split(/\W+/).filter(w => w !== '');
    let wordCount = {};
    for (let word of words) {
        if (!wordCount.hasOwnProperty(word)) {
            wordCount[word] = 1;
        } else {
            wordCount[word]++;
        }
    }

    return JSON.stringify(wordCount);
}
