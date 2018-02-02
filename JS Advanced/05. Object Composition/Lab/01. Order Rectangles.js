function orderRectangles(rectParams) {
    function createRect(width, height) {
        return {
            width,
            height,
            area: () => width * height,
            compareTo: function(other) {
                let result = other.area() - this.area();
                return result || (other.width - width);
            }
        }
    }

    let rects = [];
    for (let [width, height] of rectParams) {
        rects.push(createRect(width, height));
    }

    rects.sort((a, b) => a.compareTo(b));
    return rects;
}
