function roadRadar([speed, area]) {
    function getLimit(area) {
        switch (area) {
            case 'motorway': return 130;
            case 'interstate': return 90;
            case 'city': return 50;
            case 'residential': return 20;
        }
    }

    function getInfraction(speed, limit) {
        let overSpeed = speed - limit;
        if (overSpeed <= 0) {
            return false;
        } else if (overSpeed > 40) {
            console.log('reckless driving');
        } else if (overSpeed > 20)  {
            console.log('excessive speeding');
        } else {
            console.log('speeding');
        }
    }

    let limit = getLimit(area);
    getInfraction(speed, limit);
}
