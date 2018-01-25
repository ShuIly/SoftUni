function populationInTowns(productArr) {
    let products = {};
    for (let productInfo of productArr) {
        productInfo = productInfo.split(/ -> | : /).filter(p => p !== '');
        let town = productInfo[0];
        let productName = productInfo[1];
        let sales = Number(productInfo[2]);
        let price = Number(productInfo[3]);

        if (!products.hasOwnProperty(town)) {
            products[town] = {};
        }

        let sum = sales * price;
        if (!products[town].hasOwnProperty(productName)) {
            products[town][productName] = sum;
        } else {
            products[town][productName] += sum;
        }
    }

    for (let key in products) {
        console.log(`Town - ${key}`);
        for (let prodKey in products[key]) {
            console.log(`$$$${prodKey} : ${products[key][prodKey]}`)
        }
    }
}
