function townsJSON([empty, ...strArr]) {
    let townsArr = [];
    for (let townStr of strArr) {
        let [townName, lat, lng] = townStr.split(/\s*\|\s*/).filter(w => w !== '');
        let town = {
            Town: townName,
            Latitude: Number(lat),
            Longitude: Number(lng)
        };

        townsArr.push(town);
    }

    return JSON.stringify(townsArr);
}
