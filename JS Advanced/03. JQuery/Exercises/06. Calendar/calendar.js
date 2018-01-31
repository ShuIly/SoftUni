function calendar([day, month, year]) {
    let monthNames = ['January', 'February', 'March', 'April', 'May', 'June',
        'July', 'August', 'September', 'October', 'November', 'December'];
    let weekdays = ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'];

    let weekdaysRow = $('<tr>');
    for (let weekday of weekdays) {
        weekdaysRow.append($('<th>').text(weekday));
    }

    $('#content')
        .append($('<table>')
            .append($('<caption>').text(monthNames[month - 1] + ' ' + year))
            .append($('<tbody>')
                .append(weekdaysRow)));

    let currMonthDays = new Date(year, month, 0).getDate();
    let firstDayOfWeek = (new Date(year, month - 1, 1).getDay() + 6) % 7 + 1;

    let currDay = 1;

    let tbody = $('table tbody');

    let currMonthRows = Math.ceil((currMonthDays + firstDayOfWeek - 1) / 7);
    for (let i = 0; i < currMonthRows; ++i) {
        let currRow = $('<tr>');
        for (let j = 0; j < 7; ++j) {
            let currCell = $('<td>');
            if (currDay >= firstDayOfWeek && currDay <= currMonthDays) {
                if (currDay === day) {
                    currCell.addClass('today');
                }
                currCell.text(currDay);
                currDay++;
            } else {
                firstDayOfWeek--;
            }

            currRow.append(currCell);
        }

        tbody.append(currRow);
    }
}