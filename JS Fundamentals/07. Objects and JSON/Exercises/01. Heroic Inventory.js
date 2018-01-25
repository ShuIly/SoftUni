function heroicInventory(heroArr) {
    let heroes = [];
    for (let i = 0; i < heroArr.length; ++i) {
        let currHero = {};
        heroArr[i] = heroArr[i].split(/[ /,]/).filter(w => w !== '');
        currHero.name = heroArr[i][0];
        currHero.level = Number(heroArr[i][1]);
        currHero.items = [];

        for (let j = 2; j < heroArr[i].length; ++j) {
            currHero.items.push(heroArr[i][j]);
        }

        heroes.push(currHero);
    }

    return JSON.stringify(heroes);
}
