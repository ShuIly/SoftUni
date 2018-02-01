function getArgInfo() {
    let typeCount = [];
    for (let i = 0; i < arguments.length; i++) {
        let obj = arguments[i];
        let type = typeof obj;
        console.log(type + ': ' + obj);

        if (!typeCount[type]) {
            typeCount[type] = 1;
        } else {
            typeCount[type]++;
        }
    }

    let sortedTypes = [];
    for (let currType in typeCount) {
        sortedTypes.push([currType, typeCount[currType]]);
    }

    sortedTypes.sort((a, b) => b[1] - a[1]);
    for (let srtType of sortedTypes) {
        console.log(srtType[0] + ' = ' + srtType[1]);
    }
}
