function attachEventsListeners() {
    let convertBtn = document.getElementById('convert');
    convertBtn.addEventListener('click', convertDist);

    function convertDist() {
        let distValue = Number(document.getElementById('inputDistance').value);

        let selFrom = document.getElementById('inputUnits');
        let convertFrom = selFrom.options[selFrom.selectedIndex].value;
        switch (convertFrom) {
            case "km":
                distValue *= 1000;
                break;
            case "cm":
                distValue *= 0.01;
                break;
            case "mm":
                distValue *= 0.001;
                break;
            case "mi":
                distValue *= 1609.34;
                break;
            case "yrd":
                distValue *= 0.9144;
                break;
            case "ft":
                distValue *= 0.3048;
                break;
            case "in":
                distValue *= 0.0254;
                break;
        }

        let selTo = document.getElementById('outputUnits');
        let convertTo = selTo.options[selTo.selectedIndex].value;
        switch (convertTo) {
            case "km":
                distValue /= 1000;
                break;
            case "cm":
                distValue /= 0.01;
                break;
            case "mm":
                distValue /= 0.001;
                break;
            case "mi":
                distValue /= 1609.34;
                break;
            case "yrd":
                distValue /= 0.9144;
                break;
            case "ft":
                distValue /= 0.3048;
                break;
            case "in":
                distValue /= 0.0254;
                break;
        }

        document.getElementById('outputDistance').value = distValue;
    }
}