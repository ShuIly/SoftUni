function getFruitOrVegetable(food) {
    let fruits = ['banana', 'apple', 'kiwi', 'cherry', 'lemon', 'grapes', 'peach'];
    let vegetables = ['tomato', 'cucumber', 'pepper', 'onion', 'garlic', 'parsley'];

    if (fruits.indexOf(food) >= 0) {
        return "fruit";
    } else if (vegetables.indexOf(food) >= 0) {
        return "vegetable";
    } else {
        return "unknown";
    }
}
