function sumFirstAndLast(arr) {
    arr = arr.map(Number);
    return arr[arr.length - 1] + arr[0];
}