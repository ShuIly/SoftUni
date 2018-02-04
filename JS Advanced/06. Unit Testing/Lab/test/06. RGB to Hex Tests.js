let rgbToHexColor = require('../06. RGB to Hex').rgbToHexColor;
let expect = require('chai').expect;

describe('rgbToHexColor(reg, green, blue) Tests', function () {
    it('Should return #FFFFFF for 255, 255, 255', function () {
        expect(rgbToHexColor(255, 255, 255)).to.equal('#FFFFFF');
    });
    it('Should return #C88EFF for 200, 142, 255', function () {
        expect(rgbToHexColor(200, 142, 255)).to.equal('#C88EFF');
    });
    it('Should return #000000 for 0, 0, 0', function () {
        expect(rgbToHexColor(0, 0, 0)).to.equal('#000000');
    });
    it('Should return undefined for -1, 100, 100', function () {
        expect(rgbToHexColor(-1, 100, 100)).to.equal(undefined);
    });
    it('Should return undefined for 256, 100, 100', function () {
        expect(rgbToHexColor(-256, 100, 100)).to.equal(undefined);
    });
    it('Should return undefined for 100, -1, 100', function () {
        expect(rgbToHexColor(100, -1, 100)).to.equal(undefined);
    });
    it('Should return undefined for 100, 256, 100', function () {
        expect(rgbToHexColor(100, 256, 100)).to.equal(undefined);
    });
    it('Should return undefined for 100, 100, -1', function () {
        expect(rgbToHexColor(100, 100, -1)).to.equal(undefined);
    });
    it('Should return undefined for 100, 100, 256', function () {
        expect(rgbToHexColor(100, 100, 256)).to.equal(undefined);
    });
});