let isOddOrEven = require("../02. Even or Odd").isOddOrEven;
let expect = require("chai").expect;

describe("isOddOrEven", function () {
    it("Should return undefined with number parameter", function () {
        expect(isOddOrEven(13)).to.equal(undefined);
    });

    it("Should return undefined with object parameter", function () {
        expect(isOddOrEven({name: "pesho"})).to.equal(undefined);
    });

    it("Should return even with 'roar'", function () {
        expect(isOddOrEven("roar")).to.equal("even");
    });

    it("Should return odd with 'one'", function () {
        expect(isOddOrEven("one")).to.equal("odd");
    });

    it("Should return odd odd even with 'one', 'cat', 'is it even'", function () {
        expect(isOddOrEven("one")).to.equal("odd");
        expect(isOddOrEven("cat")).to.equal("odd");
        expect(isOddOrEven("is it even")).to.equal("even");
    });
});
