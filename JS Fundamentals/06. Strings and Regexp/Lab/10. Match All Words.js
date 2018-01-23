function matchAllWords(str) {
    let regex = /\W+/;
    let words = str.split(regex).filter(w => w !== '');

    return words.join('|');
}
