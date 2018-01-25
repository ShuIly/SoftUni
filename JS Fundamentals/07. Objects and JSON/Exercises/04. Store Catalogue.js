function storeCatalogue(productArr) {
    let products = {};
    for (let product of productArr
        .sort(function (a, b) {
            if (a > b) return 1;
            if (a < b) return -1;
            return 0;
        })) {
        if (!products.hasOwnProperty(product[0])) {
            products[product[0]] = {};
            console.log(product[0]);
        }

        console.log('  ' + product.split(':').map(e => e.trim()).join(': '));
    }
}
