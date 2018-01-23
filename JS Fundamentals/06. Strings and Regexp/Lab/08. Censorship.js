function censorship(str, censorArr) {
    for (let word of censorArr) {
        str = str.replace(new RegExp(word, 'g'), '-'.repeat(word.length));
    }

    return str;
}
