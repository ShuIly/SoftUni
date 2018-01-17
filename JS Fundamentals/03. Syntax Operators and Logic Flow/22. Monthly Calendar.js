function getCalendar(day, month, year) {
    let days = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
    let result = '<table>\n  <tr>';
    for (let i = 0; i < 7; ++i) {
        result += `<th>${days[i]}</th>`
    }
    result += '</tr>\n  <tr>';

    let firstDayOfWeek = new Date(year, month - 1, 0).getDay();
    let daysInMonth = new Date(year, month, 0).getDate();
    let daysInLastMonth = new Date(year, month - 1, 0).getDate();

    console.log(firstDayOfWeek);

    for (let i = daysInLastMonth - firstDayOfWeek; i <= daysInLastMonth; ++i) {
        result += `<td class="prev-month">${i}</td>`;
    }

    let weekDayCount = firstDayOfWeek;
    for (let i = 1; i <= daysInMonth; ++i, ++weekDayCount) {
        if (weekDayCount === 6) {
            result += '</tr>\n  <tr>';
            weekDayCount = -1;
        }

        if (i === day) {
            result += `<td class="today">${i}</td>`;
        } else {
            result += `<td>${i}</td>`;
        }
    }

    for (let i = 1; weekDayCount < 6; ++i, ++weekDayCount) {
        result += `<td class="next-month">${i}</td>`;
    }
    result += '</tr>\n</table>';

    return result;
}
