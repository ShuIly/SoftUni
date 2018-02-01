function sortArray(arr, sortMethod) {
    let sortingStrategies = {
        'asc': (a, b) => a - b,
        'desc': (a, b) => b - a
    };

    return arr.sort(sortingStrategies[sortMethod]);
}