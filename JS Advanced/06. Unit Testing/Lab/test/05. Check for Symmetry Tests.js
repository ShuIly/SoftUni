let isSymmetric = require('../05. Check for Symmetry').isSymmetric;
let expect = require('chai').expect;

describe('Test isSymmetric(arr)', function () {
    it("Should return true for [1, 1, 1]", function () {
        expect(isSymmetric([1, 1, 1])).to.equal(true);
    });
    it("Should return true for [2, 1, 2]", function () {
        expect(isSymmetric([2, 1, 2])).to.equal(true);
    });
    it("Should return false for [1, 2, 3]", function () {
        expect(isSymmetric([1, 2, 3])).to.equal(false);
    });
    it("Should return false for [1, 'text', 3]", function () {
        expect(isSymmetric([1, 'text', 3])).to.equal(false);
    });
    it("should return false for 1,2,2,1", function () {
        expect(isSymmetric(1, 2, 2, 1)).to.be.equal(false);
    });
    it("should return true for [5,'hi',{a:5},new Date(),{a:5},'hi',5]", function () {
        expect(isSymmetric([5, 'hi', {a: 5}, new Date(), {a: 5}, 'hi', 5])).to.be.equal(true);
    });
    it("should return false for [5,'hi',{a:5},new Date(),{X:5},'hi',5]", function () {
        expect(isSymmetric([5, 'hi', {a: 5}, new Date(), {X: 5}, 'hi', 5])).to.be.equal(false);
    });
});