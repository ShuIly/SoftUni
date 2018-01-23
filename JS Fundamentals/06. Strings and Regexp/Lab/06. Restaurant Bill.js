function restaurantBill(billArr) {
    let billItems = [];
    let billSum = 0;
    for (let i = 0; i < billArr.length; i += 2) {
        billItems.push(billArr[i]);
        billSum += Number(billArr[i + 1]);
    }

    return `You purchased ${billItems.join(', ')} for a total sum of ${billSum}`;
}