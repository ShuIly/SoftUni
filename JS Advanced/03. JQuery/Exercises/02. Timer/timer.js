function timer() {
    let seconds = 0;
    let minutes = 0;
    let hours = 0;

    let secondsSpan = $('div#timer #seconds');
    let minutesSpan = $('div#timer #minutes');
    let hoursSpan = $('div#timer #hours');

    $('button#start-timer').on('click', start);
    $('button#stop-timer').on('click', stop);

    let timerInt;

    function start() {
        clearInterval(timerInt);
        timerInt = setInterval(tick, 1000);
        function tick() {
            seconds++;

            minutes += Math.trunc(seconds / 60);
            hours += Math.trunc(minutes / 60);

            minutes %= 60;
            seconds %= 60;

            secondsSpan.text(('0' + seconds).slice(-2));
            minutesSpan.text(('0' + minutes).slice(-2));
            hoursSpan.text(('0' + hours).slice(-2));
        }
    }

    function stop() {
        clearInterval(timerInt);
    }
}