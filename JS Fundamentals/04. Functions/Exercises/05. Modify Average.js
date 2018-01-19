function modifyAverage(input) {
    input += '';
    function getAverage(num) {
        let sum = 0;
        for (let digit of num) {
            sum += parseInt(digit);
        }

        return sum / num.length;
    }

    while (getAverage(input) <= 5) {
        input += '9';
    }

    console.log(input);
}
