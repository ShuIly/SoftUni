function breakfastRobot() {
    let ingredients = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };

    function useIngredient(ingrArr, mealsCount) {
        for (let [ingr, quantity] of ingrArr) {
            if (ingredients[ingr] < quantity * mealsCount) {
                return `Error: not enough ${ingr} in stock`;
            }
        }

        for (let [ingr, quantity] of ingrArr) {
            ingredients[ingr] -= quantity * mealsCount;
        }

        return 'Success';
    }

    let prepareMeals = {
        apple: (quantity) => useIngredient([['carbohydrate', 1], ['flavour', 2]], quantity),
        coke: (quantity) => useIngredient([['carbohydrate', 10], ['flavour', 20]], quantity),
        burger: (quantity) => useIngredient([['carbohydrate', 5], ['fat', 7], ['flavour', 3]], quantity),
        omelet: (quantity) => useIngredient([['protein', 5], ['fat', 1], ['flavour', 1]], quantity),
        cheverme: (quantity) => useIngredient([['protein', 10], ['carbohydrate', 10], ['fat', 10], ['flavour', 10]], quantity),
    };

    function report() {
        return Object.keys(ingredients)
            .map(i => `${i}=${ingredients[i]}`)
            .join(' ');
    }

    return function cmdManager(cmdString) {
        let [command, product, quantity] = cmdString.split(' ');
        switch (command) {
            case 'restock':
                ingredients[product] += Number(quantity);
                return 'Success';
            case 'prepare':
                return prepareMeals[product](Number(quantity));
            case 'report':
                return report();
        }
    }
}
