function search() {
    let text = $('#searchText').val();
    let matches = $(`ul#towns li:contains(${text})`);
    matches.css('font-weight', 'bold');

    $('div#result').text(matches.length + ' matches found.');
}