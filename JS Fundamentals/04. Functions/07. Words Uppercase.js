function wordsUppercase(str) {
    let words = str.toUpperCase().split(/\W+/).filter(w => w !== '');
    let result = words.slice(0, words.length).join(', ');
    return result;
}
