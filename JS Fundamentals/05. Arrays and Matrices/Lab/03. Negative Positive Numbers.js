function modifyArray(arr) {
    arr = arr.map(Number);
    let modifiedArr = [];

    for (let num of arr) {
        if (num < 0) {
            modifiedArr.unshift(num);
        } else {
            modifiedArr.push(num);
        }
    }

    for (let num of modifiedArr) {
        console.log(num);
    }
}
