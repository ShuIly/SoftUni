function rotateArr(input) {
    let n = Number(input[input.length - 1]);
    input.pop();

    let rotateCount = n % input.length;
    for (let i = 0; i < rotateCount; ++i) {
        input.unshift(input.pop());
    }

    return input.join(' ');
}