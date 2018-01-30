function attachEvents() {
    $('ul#items li').click(selectItem);
    $('#showTownsButton').click(showSelected);

    function selectItem() {
        if ($(this).attr('data-selected')) {
            $(this)
                .removeAttr('data-selected')
                .css('background', '');
        } else {
            $(this)
                .attr('data-selected', 'true')
                .css('background', '#DDD');
        }
    }

    function showSelected() {
        let towns = $("ul#items li[data-selected]");
        let result = 'Selected towns: ' + towns.toArray().map(t => t.textContent).join(', ');
        $('div#selectedTowns').text(result);
    }
}
