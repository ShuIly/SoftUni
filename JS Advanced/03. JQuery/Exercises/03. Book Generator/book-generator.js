(function bookGenerator() {
    let id = 1;

    return function createBook(selector, title, author, isbn) {
        let bookID = 'book' + id;
        let anchorEl = $(selector);
        anchorEl
            .append($(`<div id="${bookID}" style="border: medium none;">`)
                .append($(`<p class="title">${title}</p>`))
                .append($(`<p class="author">${author}</p>`))
                .append($(`<p class="isbn">${isbn}</p>`))
                .append($(`<button>Select</button>`).on('click', selectBook))
                .append($(`<button>Deselect</button>`).on('click', deselectBook)));

        id++;
    }

    function selectBook() {
        let bookDiv = $(this).parent();
        bookDiv.css('border', '2px solid blue');
    }

    function deselectBook() {
        let bookDiv = $(this).parent();
        bookDiv.css('border', '');
    }
}())
