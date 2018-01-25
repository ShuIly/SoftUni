function countWords([str]) {
    let words = str.toLowerCase().split(/\W+/).filter(w => w !== '');
    let wordCount = new Map();
    for (let word of words) {
        if (!wordCount.has(word)) {
            wordCount.set(word, 1);
        } else {
            wordCount.set(word, wordCount.get(word) + 1);
        }
    }

    let result = [];
    let wordCountKeys = Array.from(wordCount.keys()).sort();
    for (let key of wordCountKeys) {
        result.push(`'${key}' -> ${wordCount.get(key)} times`);
    }

    return result.join('\n');
}
