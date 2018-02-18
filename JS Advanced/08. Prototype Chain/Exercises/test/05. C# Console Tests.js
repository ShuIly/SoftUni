let Console = require('../05. C# Console').Console;
let expect = require('chai').expect;

describe('Console', function () {
    describe('Single arguments', function () {
        it('should return passed string if only a single argument is passed', function () {
            let argument = 'some string';
            expect(Console.writeLine(argument)).to.equal(argument);
        });

        it('should return JSON representation if argument passed is object', function () {
            let object = { text: 'some text', args: ['some args', 'some other args']};
            expect(Console.writeLine(object)).to.equal(JSON.stringify(object));
        });
    });

    describe('Template string with parameters', function () {
        it('should throw TypeError if first argument is not a string', function () {
            let object = { text: 'some text', args: ['some args', 'some other args']};
            expect(() => (Console.writeLine(object, 'parameter1'))).to.throw(TypeError, 'No string format given!');
        });

        it('should throw RangeError if number of parameters do not correspond to number of placeholders', function () {
            expect(() => (Console.writeLine('Hello, {0}, my name is {1}', 'Pesho'))).to.throw(RangeError, 'Incorrect amount of parameters given!');
        });

        it('should throw RangeError if template contains placeholders with incorrect indices', function () {
            expect(() => (Console.writeLine('Hello, {23}.', 'Pesho'))).to.throw(RangeError, 'Incorrect placeholders given!');
        });

        it('should correctly swap placeholders with string parameters', function () {
            expect(Console.writeLine('Hello, {0}, my name is {1}.', 'Pesho', 'Andrew')).to.equal('Hello, Pesho, my name is Andrew.')
        });
    });
});