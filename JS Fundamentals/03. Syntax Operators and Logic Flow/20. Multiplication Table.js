function getMultiplicationTable(n) {
    let result = '<table border="1">\n  <tr><th>x</th>';
    for (let i = 1; i <= n; ++i) {
        result += `<th>${i}</th>`;
    }
    result += '</tr>\n';

    for (let i = 1; i <= n; ++i) {
        result += `  <tr><th>${i}</th>`;
        for (let j = i, count = 1; count <= n; j += i, count++) {
            result += `<td>${j}</td>`;
        }
        result += '</tr>\n';
    }
    result += '</table>';

    return result;
}
