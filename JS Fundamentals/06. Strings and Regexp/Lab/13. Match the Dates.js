function matchDates(strArr) {
    let regex = /\b(\d{1,2})-([A-Z][a-z]{2})-(\d{1,4})\b/g;
    let dateArr = [];
    for (let str of strArr) {
        let match;
        while ((match = regex.exec(str)) !== null) {
            dateArr.push(`${match[0]} (Day: ${match[1]}, Month: ${match[2]}, Year: ${match[3]})`);
        }
    }

    return dateArr.join('\n');
}
