class Textbox {
    constructor(selector, regex) {
        this.elements = $(selector);
        this.invalidSymbols = regex;
    }

    get elements() {
        return this._elements;
    }

    set elements(value) {
        this._elements = value;
    }

    get invalidSymbols() {
        return this._invalidSymbols;
    }

    set invalidSymbols(value) {
        this._invalidSymbols = value;
    }

    get value() {
        return this.elements.val();
    }

    set value(value) {
        return this.elements.val(value);
    }

    isValid() {
        return !this.invalidSymbols.test(this.value);
    }
}

let textbox = new Textbox(".textbox", /[^a-zA-Z0-9]/);
let inputs = $('.textbox');

inputs.on('input', function () {
    console.log(textbox.value);
});
