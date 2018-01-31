function increment(selector) {
    let selectedEl = $(selector);
    selectedEl
        .append($('<textarea class="counter" disabled="disabled">0</textarea>'))
        .append($('<button class="btn" id="incrementBtn">Increment</button>')
            .on('click', incrementTextarea))
        .append($('<button class="btn" id="addBtn">Add</button>')
            .on('click', addItem))
        .append($('<ul class="results"</ul>'));

    function incrementTextarea() {
        let textarea = $('textarea.counter');
        let num = Number(textarea.text());
        textarea.text(num + 1);
    }
    
    function addItem() {
        let itemText = $('textarea.counter').text();
        $('ul.results').append(`<li>${itemText}</li>`);
    }
}