let validate = require('../01. Request Validator').validate;
let expect = require('chai').expect;

// Note: this is not needed for Judge.
describe('validate', function () {
    it("Should return valid request", function () {
        let request = {
            method: 'GET',
            uri: 'svn.public.catalog',
            version: 'HTTP/1.1',
            message: ''
        };

        expect(validate(request)).to.equal(request);
    });

    it("Should return 'Invalid request header: Invalid Method'", function () {
        let request = {
            method: 'OPTIONS',
            uri: 'git.master',
            version: 'HTTP/1.1',
            message: '-recursive'
        };

        expect(() => validate(request)).to.throw(Error, 'Invalid request header: Invalid Method');
    });

    it("Should return 'Invalid request header: Invalid Method'", function () {
        let request = {
            method: 'OPTIONS',
            uri: 'git.master',
            version: 'HTTP/1.1',
            message: '-recursive'
        };

        expect(() => validate(request)).to.throw(Error, 'Invalid request header: Invalid Method');
    });

    it("Should return 'Invalid request header: Invalid URI'", function () {
        let request = {
            method: 'GET',
            uri: '',
            version: 'HTTP/1.1',
            message: '-recursive'
        };

        expect(() => validate(request)).to.throw(Error, 'Invalid request header: Invalid URI');
    });
});