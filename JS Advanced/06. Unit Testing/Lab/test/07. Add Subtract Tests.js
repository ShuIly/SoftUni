let createCalculator = require("../07. Add Subtract").createCalculator;
let expect = require("chai").expect;

describe("createCalculator() Tests", function () {
    let calculator;
    beforeEach(function () {
        calculator = createCalculator();
    });

    it("Should return 0 for get()", function () {
        expect(calculator.get()).to.equal(0);
    });

    it("Should return 0 for get()", function () {
        expect(calculator.get()).to.equal(0);
    });

    it("Should return 7 to value for add(7)", function () {
        calculator.add(7);
        expect(calculator.get()).to.equal(7);
    });

    it("Should return -2 to value for subtract(2)", function () {
        calculator.subtract(2);
        expect(calculator.get()).to.equal(-2);
    });

    it("Should return 10 to value for add(20) subtract(10)", function () {
        calculator.add(20);
        calculator.subtract(10);
        expect(calculator.get()).to.equal(10);
    });

    it("Should return 6.5 to value for add(5) add(1.5)", function () {
        calculator.add(5);
        calculator.add(1.5);
        expect(calculator.get()).to.equal(6.5);
    });

    it("Should return -10 to value for add('5') add('-15')", function () {
        calculator.add('5');
        calculator.add('-15');
        expect(calculator.get()).to.equal(-10);
    });

    it("Should return 10 to value for subtract(-5) subtract('-5')", function () {
        calculator.subtract(-5);
        calculator.subtract('-5');
        expect(calculator.get()).to.equal(10);
    });

    it("Should return NaN to value for add('text')", function () {
        calculator.add('text');
        expect(calculator.get()).to.be.NaN;
    });

    it("Should return NaN to value for subtract('text')", function () {
        calculator.subtract('text');
        expect(calculator.get()).to.be.NaN;
    });
});
