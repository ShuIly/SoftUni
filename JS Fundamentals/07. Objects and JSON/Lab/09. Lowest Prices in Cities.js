function lowestPrices(townArr) {
    let products = new Map();
    for (let productInfo of townArr) {
        productInfo = productInfo.split(/\|/).map(t => t.trim());
        let townName = productInfo[0];
        let productName = productInfo[1];
        let price = Number(productInfo[2]);

        if (!products.has(productName) || products.get(productName).price > price) {
            products.set(productName, {town: townName, price: price });
        }
    }

    for (let productKey of Array.from(products.keys())) {
        console.log(`${productKey} -> ${products.get(productKey).price} (${products.get(productKey).town})`);
    }
}
