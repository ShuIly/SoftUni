function numbersSequence(n, k) {
    let arr = [1];
    for (let i = 1; i < n; i++) {
        let numToBeAdded = 0;
        let count = arr.length < k ? 0 : arr.length - k;

        for (let j = i - 1; j >= count; --j) {
            numToBeAdded += arr[j];
        }

        arr.push(numToBeAdded);
    }

    console.log(arr.join(' '));
}
