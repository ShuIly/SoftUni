function rectangleOfStars(count) {
    count = Number(count);

    function printStars(number) {
        console.log('* '.repeat(number));
    }

    for(let i = 0; i < count; i++) {
        printStars(count);
    }
}
