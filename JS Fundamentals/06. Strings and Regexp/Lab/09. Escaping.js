function escapeHtml(strArr) {
    let forbidden = ["&", "<", ">", '"'];
    let allowed = ["&amp;", "&lt;", "&gt;", "&quot;"];

    let result = '<ul>\n';
    for (let line of strArr) {
        for (let i = 0; i < forbidden.length; ++i) {
            line = line.split(forbidden[i]).join(allowed[i]);
        }

        result += `  <li>${line}</li>\n`;
    }

    result += '</ul>';
    return result;
}