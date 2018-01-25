function autoEngineeringCompany(carArr) {
    let cars = {};
    for (let carInfo of carArr) {
        carInfo = carInfo.split(' | ');
        let brand = carInfo[0];
        let model = carInfo[1];
        let amount = Number(carInfo[2]);

        if (!cars.hasOwnProperty(brand)) {
            cars[brand] = {};
        }

        if (!cars[brand].hasOwnProperty(model)) {
            cars[brand][model] = amount;
        } else {
            cars[brand][model] += amount;
        }
    }

    for (let brand in cars) {
        console.log(brand);
        for (let model in cars[brand]) {
            console.log(`###${model} -> ${cars[brand][model]}`)
        }
    }
}