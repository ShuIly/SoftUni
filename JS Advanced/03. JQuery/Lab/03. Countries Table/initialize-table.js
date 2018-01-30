function initializeTable() {
    $('#createLink').click(addCountry);

    function createCountry(country, capital) {
        let row = $('<tr>')
            .append($(`<td>${country}</td>`))
            .append($(`<td>${capital}</td>`))
            .append($('<td>')
                .append($('<a href="#">[Up]</a>').click(moveUp))
                .append($('<a href="#">[Down]</a>').click(moveDown))
                .append($('<a href="#">[Delete]</a>').click(deleteRow)));

        row.css('display', 'none');
        $('#countriesTable').append(row);
        row.fadeIn();
    }

    createCountry('Bulgaria', 'Sofia');
    createCountry('Germany', 'Berlin');
    createCountry('Russia', 'Moscow');
    adjustLinks();

    function addCountry() {
        let country = $('#newCountryText').val();
        let capital = $('#newCapitalText').val();
        createCountry(country, capital);
        adjustLinks();
    }

    function adjustLinks() {
        $('#countriesTable a').css('display', 'inline');
        let rows = $('#countriesTable tr');
        $(rows[2]).find("a:contains('Up')").css('display', 'none');
        $(rows[rows.length - 1]).find("a:contains('Down')").css('display', 'none');
    }

    function moveUp() {
        let row = $(this).parent().parent();
        console.log(row);
        row.insertBefore(row.prev());
        adjustLinks();
    }

    function moveDown() {
        let row = $(this).parent().parent();
        row.insertAfter(row.next());
        adjustLinks();
    }

    function deleteRow() {
        let row = $(this).parent().parent();
        row.remove();
        adjustLinks();
    }
}