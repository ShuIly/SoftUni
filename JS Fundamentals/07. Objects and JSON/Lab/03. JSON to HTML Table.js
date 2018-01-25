function scoreToHTML(json) {
    function escapeHtml(text) {
        let map = {
            '&': '&amp;',
            '<': '&lt;',
            '>': '&gt;',
            '"': '&quot;',
            "'": '&#39;'
        };

        return text.replace(/[&<>"']/g, (m) => map[m]);
    }

    let usersArr = JSON.parse(json);
    let html = '<table>\n   <tr>';
    let propNames = Object.getOwnPropertyNames(usersArr[0]);
    propNames.forEach(p => html += `<th>${p}</th>`);
    html += '</tr>\n';

    for (let user of usersArr) {
        html += '   <tr>';
        for (let prop of propNames) {
            let propVal = user[prop];
            if (typeof propVal === 'string')  {
                propVal = escapeHtml(propVal);
            }
            html += `<td>${propVal}</td>`;
        }
        html += '</tr>\n';
    }

    html += '</table>';

    return html;
}

console.log(scoreToHTML('[{"Name":"Pesho <div>-a","Age":20,"City":"Sofia"},{"Name":"Gosho","Age":18,"City":"Plovdiv"},{"Name":"Angel","Age":18,"City":"Veliko Tarnovo"}]'));
