function extractLinks(str) {
    let match = str.join('\n').match(/www\.[A-Za-z\d-]+\.[a-z]+(?:\.[a-z]+)*/g);
    if (match !== null) return match.join('\n');
}