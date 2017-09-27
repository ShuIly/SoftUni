function reverseOrder(arr) {
    let nums = arr.map(Number);
    for (let i = arr.length - 1; i >= 0; --i) {
        console.log(nums[i]);
    }
}