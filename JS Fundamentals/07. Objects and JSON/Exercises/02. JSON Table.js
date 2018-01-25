function jsonTable(jsonArr) {
    let html = '<table>\n';
    for (let json of jsonArr) {
        html += '\t<tr>\n';
        let obj = JSON.parse(json);
        for (let prop of Object.getOwnPropertyNames(obj)) {
            html += `\t\t<td>${obj[prop]}</td>\n`;
        }
        html += '\t<tr>\n';
    }
    html += '</table>';

    return html;
}
