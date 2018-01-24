function getMatchCount(str, word) {
    let match = str.match(new RegExp(`\\b${word}\\b`, 'gi'));

    return match !== null ? match.length : 0;
}
