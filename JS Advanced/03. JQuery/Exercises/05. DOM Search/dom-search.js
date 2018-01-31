function domSearch(selector, searchSensitive) {
    let itemHandler = (function () {
        function addItem() {
            let input = $('div.add-controls input');
            $('div.result-controls ul.items-list')
                .append($('<li class="list-item">')
                    .append($('<a class="button">X</a>')
                        .on('click', itemHandler.removeItem))
                    .append($(`<strong>${input.val()}</strong>`)));

            input.val('');
        }

        function removeItem() {
            $(this).parent().remove();
        }

        function searchList() {
            let items = $('.items-list .list-item');
            if (items.length === 0) {
                return;
            }

            let searchText = $('.search-controls input').val();

            if (searchSensitive) {
                for (let item of items) {
                    if ($(item).find('strong').text().indexOf(searchText) < 0) {
                        $(item).css('display', 'none')
                    } else {
                        $(item).css('display', 'block');
                    }
                }
            } else {
                searchText = searchText.toLowerCase();
                for (let item of items) {
                    if ($(item).find('strong').text().toLowerCase().indexOf(searchText) < 0) {
                        $(item).css('display', 'none')
                    } else {
                        $(item).css('display', 'block');
                    }
                }
            }
        }

        return {
            addItem,
            removeItem,
            searchList
        }
    })();

    $(selector)
        .append($('<div class="add-controls">')
            .append($('<label>Enter text: </label>')
                .append($('<input>')))
            .append($('<a class="button" style="display: inline-block;">Add</a>')
                .on('click', itemHandler.addItem)))
        .append($('<div class="search-controls">')
            .append($('<label>Search:</label>'))
            .append($('<input>').on('input', itemHandler.searchList)))
        .append($('<div class="result-controls">')
            .append($('<ul class="items-list">')));
}
