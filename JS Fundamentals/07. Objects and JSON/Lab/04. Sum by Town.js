function sumByTown(strArr) {
    let towns = {};
    for (let i = 0; i < strArr.length; i += 2) {
        if (!towns.hasOwnProperty(strArr[i])) {
            towns[strArr[i]] = 0;
        }
        towns[strArr[i]] += Number(strArr[i + 1]);
    }

    return JSON.stringify(towns);
}
