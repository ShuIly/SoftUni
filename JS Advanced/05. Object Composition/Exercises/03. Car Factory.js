function modifyCar(car) {
    let engines = [{power: 90, volume: 1800}, {power: 120, volume: 2400}, {power: 200, volume: 3500}];
    let carriages = {
        hatchback: {type: 'hatchback', color: car.color},
        coupe: {type: 'coupe', color: car.color}
    };
    let wheelsize = car.wheelsize % 2 === 0 ? car.wheelsize - 1 : car.wheelsize;

    return {
        model: car.model,
        engine: engines.find(e => e.power >= car.power),
        carriage: carriages[car.carriage],
        wheels: Array(4).fill(wheelsize)
    }
}