let mathEnforcer = require('../04. Math Enforcer').mathEnforcer;
let expect = require("chai").expect;

describe('mathEnforcer', function () {
    describe('addFive', function () {
        it('with a non-number parameter, should return undefined', function () {
            expect(mathEnforcer.addFive('text')).to.equal(undefined);
        });

        it('with a positive number parameter, should return correct result', function () {
            expect(mathEnforcer.addFive(5)).to.equal(10);
        });

        it('with a negative number parameter, should return correct result', function () {
            expect(mathEnforcer.addFive(-10)).to.equal(-5);
        });

        it('with a floating point number parameter, should return result within 0.01', function () {
            expect(mathEnforcer.addFive(0.311896426)).to.be.closeTo(5.311896426, 0.01);
        });
    });

    describe('subtractTen', function () {
        it('with a non-number parameter, should return undefined', function () {
            expect(mathEnforcer.subtractTen('text')).to.equal(undefined);
        });

        it('with a positive number parameter, should return correct result', function () {
            expect(mathEnforcer.subtractTen(10)).to.equal(0);
        });

        it('with a negative number parameter, should return correct result', function () {
            expect(mathEnforcer.subtractTen(-10)).to.equal(-20);
        });

        it('with a floating point number parameter, should return result within 0.01', function () {
            expect(mathEnforcer.subtractTen(11.311896426)).to.be.closeTo(1.311896426, 0.01);
        });
    });

    describe('sum', function () {
        it('with a non-number parameter, should return undefined', function () {
            expect(mathEnforcer.sum('text', 0)).to.equal(undefined);
        });

        it('with non-number parameters, should return undefined', function () {
            expect(mathEnforcer.sum(0, 'text')).to.equal(undefined);
        });

        it('with positive number parameters, should return correct result', function () {
            expect(mathEnforcer.sum(4, 5)).to.equal(9);
        });

        it('with negative number parameters, should return correct result', function () {
            expect(mathEnforcer.sum(-10, -30)).to.equal(-40);
        });

        it('with negative and positive number parameters, should return correct result', function () {
            expect(mathEnforcer.sum(32, -30)).to.equal(2);
        });

        it('with a floating point number parameter, should return result within 0.01', function () {
            expect(mathEnforcer.sum(123, 0.311896426)).to.be.closeTo(123.311896426, 0.01);
        });

        it('with a floating point number parameter, should return result within 0.01', function () {
            expect(mathEnforcer.sum(0.1, 0.311896426)).to.be.closeTo(0.411896426, 0.01);
        });
    });
});
