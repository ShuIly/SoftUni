function sortByTwoCriteria(arr) {
    return arr.sort(function(a, b) {
        let lengthDiff = a.length - b.length;
        if (lengthDiff === 0) {
            if (a < b) return -1;
            if (a > b) return 1;
            return 0;
        }

        return lengthDiff;
    }).join('\n');
}