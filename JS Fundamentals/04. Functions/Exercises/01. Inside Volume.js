function checkInsideVolume(points) {
    function isInside(x, y, z) {
        let x1 = 10, x2 = 50;
        let y1 = 20, y2 = 80;
        let z1 = 15, z2 = 50;

        return x >= x1 && x <= x2 &&
            y >= y1 && y <= y2 &&
            z >= z1 && z <= z2;
    }

    for (let i = 0; i < points.length; i += 3) {
        console.log(isInside(points[i], points[i + 1], points[i + 2]) ?
        'inside' : 'outside');
    }
}

