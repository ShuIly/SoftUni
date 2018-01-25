(usernames) => usernames.sort(function (a, b) {
    let lengthDiff = a.length - b.length;
    if (lengthDiff !== 0) return lengthDiff;
    if (a > b) return 1;
    if (a < b) return -1;
    return 0;
}).filter((el, i, arr) => i === arr.indexOf(el) ? 1 : 0)
    .join('\n')