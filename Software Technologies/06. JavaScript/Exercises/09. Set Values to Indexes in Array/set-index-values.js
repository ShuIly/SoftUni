function indexValues(arr) {
    let N = Number(arr[0]);
    let numArr = new Array(N).fill(0);
    for (let i = 1; i < arr.length; ++i) {
        let inputTokens = arr[i].split(' - ');
        let index = inputTokens[0];
        let num = inputTokens[1];
        numArr[index] = num;
    }

    for (let num of numArr) {
        console.log(num);
    }
}