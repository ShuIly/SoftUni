function attachEvents() {
    $('.button').click(buttonClick);

    function buttonClick() {
        $('.button').removeClass('selected');
        $(this).addClass('selected');
    }
}