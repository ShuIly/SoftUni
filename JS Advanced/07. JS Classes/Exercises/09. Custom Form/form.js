let result = (function () {
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
            this.elements.val(value);
        }

        isValid() {
            return !this.invalidSymbols.test(this.value);
        }
    }

    class Form {
        constructor() {
            this._element = $('<div class="form">');
            for (let textbox of arguments) {
                if (!(textbox instanceof Textbox)) {
                    throw Error('Instance of Textbox expected.');
                }
            }

            this._textboxes = arguments;
            for (let textbox of this._textboxes) {
                this._element.append(textbox.elements);
            }
        }

        submit() {
            let allValid = true;
            for (let textbox of this._textboxes) {
                if (textbox.isValid()) {
                    textbox.elements.css('border', '2px solid green');
                } else {
                    textbox.elements.css('border', '2px solid red');
                    allValid = false;
                }
            }

            return allValid;
        }

        attach(selector) {
            $(selector).append(this._element);
        }
    }

    return {
        Textbox: Textbox,
        Form: Form
    }
}())

let Textbox = result.Textbox;
let Form = result.Form;
let username = new Textbox("#username", /[^a-zA-Z0-9]/);
let password = new Textbox("#password", /[^a-zA-Z]/);
username.value = "username";
password.value = "password2";
let form = new Form(username, password);
form.attach("#root");
