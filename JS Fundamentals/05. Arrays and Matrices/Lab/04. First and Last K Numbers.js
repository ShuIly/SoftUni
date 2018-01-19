function firstAndLastElements(input) {
    input = input.map(Number);
    let k = input[0];

    for (let i = 1; i <= k; ++i) {
        console.log(input[i]);
    }

    for (let i = input.length - k; i <= input.length; ++i) {
        console.log(input[i]);
    }
}