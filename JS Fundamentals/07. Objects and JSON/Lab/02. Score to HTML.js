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

    let html = '<table>\n  <tr><th>name</th><th>score</th></tr>\n';
    let usersArr = JSON.parse(json);
    for (let user of usersArr) {
        html += `   <tr><td>${escapeHtml(user.name)}</td><td>${user.score}</td></tr>\n`;
    }
    html += '</table>';

    return html;
}
