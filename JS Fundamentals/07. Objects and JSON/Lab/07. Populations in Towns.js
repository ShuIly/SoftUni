function populationInTowns(townArr) {
    let towns = {};
    for (let townInfo of townArr) {
        townInfo = townInfo.split(/\s*<->\s*/);
        let townName = townInfo[0];
        let townPopulation = Number(townInfo[1]);
        if (!towns.hasOwnProperty(townName)) {
            towns[townName] = townPopulation;
        } else {
            towns[townName] += townPopulation;
        }
    }

    let result = [];
    for (let key in towns) {
        result.push(`${key} : ${towns[key]}`);
    }

    return result.join('\n');
}