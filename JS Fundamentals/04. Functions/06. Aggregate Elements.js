function aggregateElements(arr) {
    function sum(elements) {
        let result = 0;
        for (let element of elements) {
            result += element;
        }

        return result;
    }

    function concat(elements) {
        let result = '';

        for (let element of elements) {
            result += element;
        }

        return result;
    }

    console.log(sum(arr) + '\n' +
        sum(arr.map(e => 1 / e)) + '\n' +
        concat(arr))
}
