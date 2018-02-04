let sum = require('../04. Sum of Numbers').sum;
let expect = require('chai').expect;

describe('sum(arr) - sum array of numbers', function () {
    it("Should return 3 for [1, 2]", function() {
        expect(sum([1, 2])).to.be.equal(3);
    });
    it("Should return NaN for ['text', 1]", function () {
        expect(sum(['test', 1])).to.be.NaN;
    });
    it("Should return NaN for ['text', 1]", function () {
        expect(sum(['test', 1])).to.be.NaN;
    });
});
