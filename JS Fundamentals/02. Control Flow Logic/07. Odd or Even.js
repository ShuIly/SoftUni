function getOddOrEven(num) {
    if (num % 1 !== 0) return "invalid";
    return num % 2 === 0 ? "even" : "odd";
}