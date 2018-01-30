function extractText() {
    let liArr = $('ul#items li').toArray().map(li => li.textContent);
    $('#result').text(liArr.join(', '));
}