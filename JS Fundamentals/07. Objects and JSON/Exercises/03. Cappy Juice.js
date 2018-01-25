function cappyJuice(fruitArr) {
    let fruits = {};
    let fruitBottles = {};
    for (let fruitInfo of fruitArr) {
        fruitInfo = fruitInfo.split(/ => /).filter(w => w !== '');

        let fruitName = fruitInfo[0];
        let fruitAmount = Number(fruitInfo[1]);

        if (!fruits.hasOwnProperty(fruitName)) {
            fruits[fruitName] = fruitAmount;
        } else {
            fruits[fruitName] += fruitAmount;
        }

        let bottleAmount = Math.floor(fruits[fruitName] / 1000);
        if (bottleAmount > 0) {
            fruits[fruitName] -= bottleAmount * 1000;
            if (!fruitBottles.hasOwnProperty(fruitName)) {
                fruitBottles[fruitName] = bottleAmount;
            } else {
                fruitBottles[fruitName] += bottleAmount;
            }
        }
    }

    let result = [];
    for (let key in fruitBottles) {
        result.push(key + ' => ' + fruitBottles[key]);
    }

    return result.join('\n');
}