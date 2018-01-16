function sumAndVat(arr) {
    let sum = 0;
    for (let num of arr) {
        sum += parseFloat(num);
    }

    let vat = sum / 5;
    let total = sum + vat;

    console.log(sum);
    console.log(vat);
    console.log(total);
}
