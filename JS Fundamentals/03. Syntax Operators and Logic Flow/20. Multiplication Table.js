function getMultiplicationTable(n) {
    let result = '<table border="1">\n  <tr><th>x</th>';
    for (let i = 1; i <= n; ++i) {
        result += `<td>${i}</td>`;
    }
    result += '</tr>\n';

    for (let i = 1; i <= n; ++i) {
        result += `  <tr><th>${i}</th>`;
        for (let j = 1; j <= n; ++j) {
            result += `<td>${j}</td>`;
        }
        result += '</tr>\n';
    }
    result += '</table>';

    return result;
}

