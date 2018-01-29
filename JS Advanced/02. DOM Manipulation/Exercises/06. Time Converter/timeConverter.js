function attachEventsListeners() {
    let buttons = document.querySelectorAll('div input[type=button]');
    for (let button of buttons) {
        button.addEventListener('click', convertTime);
    }

    function convertTime() {
        let convertedInput = this.parentNode.querySelector('input[type=text]');
        let timeValue = Number(convertedInput.value);
        let timeInSeconds = 1;
        let timeFormat = convertedInput.id;
        switch (timeFormat) {
            case "seconds":
                timeInSeconds = timeValue;
                break;
            case "minutes":
                timeInSeconds = timeValue * 60;
                break;
            case "hours":
                timeInSeconds = timeValue * 3600;
                break;
            case "days":
                timeInSeconds = timeValue * 86400;
                break
        }

        let timeInputs = document.querySelectorAll('div input[type=text]');
        timeInputs[0].value = timeInSeconds / 86400;
        timeInputs[1].value = timeInSeconds / 3600;
        timeInputs[2].value = timeInSeconds / 60;
        timeInputs[3].value = timeInSeconds;
    }
}