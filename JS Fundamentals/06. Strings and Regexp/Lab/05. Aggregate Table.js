function aggregateTable(townArr) {
    let towns = [];
    let townSum = 0;
    for (let townInfo of townArr) {
        townInfo = townInfo.split('|').filter(x => x !== '');
        towns.push(townInfo[0].trim());
        townSum += Number(townInfo[1].trim());
    }

    return towns.join(', ') + '\n' + townSum;
}