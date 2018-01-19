function cookNumbers(input) {
    function modifyNum(num, operation) {
        switch (operation) {
            case 'chop': return num / 2;
            case 'dice': return Math.sqrt(num);
            case 'spice': return num + 1;
            case 'bake': return num * 3;
            case 'fillet': return num - num / 5;
        }
    }

    let num = input[0];

    for (let i = 1; i < input.length; ++i) {
        num = modifyNum(num, input[i]);
        console.log(num);
    }
}
