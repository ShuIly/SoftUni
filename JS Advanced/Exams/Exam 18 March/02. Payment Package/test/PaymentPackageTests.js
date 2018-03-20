const PaymentPackage = require('../PaymentPackage');
const expect = require('chai').expect;

describe("PaymentPackage tests", function () {
    it("It should be able to be instantiated with two parameters – a string name and number value", function () {
        let hrPack = new PaymentPackage('HR Services', 20);
        expect(hrPack).to.equal(hrPack);
    });

    it("It should be able to get name", function () {
        let hrPack = new PaymentPackage('HR Services', 20);
        expect(hrPack.name).to.equal('HR Services');
    });

    it("It should be able to set name", function () {
        let hrPack = new PaymentPackage('HR Services', 20);
        hrPack.name = 'Str';
        expect(hrPack.name).to.equal('Str');
    });

    it("It should be able to get value", function () {
        let hrPack = new PaymentPackage('HR Services', 20);
        expect(hrPack.value).to.equal(20);
    });

    it("It should be able to set value", function () {
        let hrPack = new PaymentPackage('HR Services', 20);
        hrPack.value = 40;
        expect(hrPack.value).to.equal(40);
    });

    it("It should be able to get VAT", function () {
        let hrPack = new PaymentPackage('HR Services', 20);
        expect(hrPack.VAT).to.equal(20);
    });

    it("It should be able to set VAT", function () {
        let hrPack = new PaymentPackage('HR Services', 20);
        hrPack.VAT = 40;
        expect(hrPack.VAT).to.equal(40);
    });

    it("It should be able to get active", function () {
        let hrPack = new PaymentPackage('HR Services', 20);
        expect(hrPack.active).to.equal(true);
    });

    it("It should be able to set active", function () {
        let hrPack = new PaymentPackage('HR Services', 20);
        hrPack.active = false;
        expect(hrPack.active).to.equal(false);
    });

    it("It should return a string, containing an overview of the instance", function () {
        let hrPack = new PaymentPackage('HR Services', 1500);
        expect(hrPack.toString()).to.equal('Package: HR Services\n- Value (excl. VAT): 1500\n- Value (VAT 20%): 1800');
    });

    it("It should append the label '(inactive)' to the printed name if package is not active", function () {
        let hrPack = new PaymentPackage('HR Services', 1500);
        hrPack.active = false;
        expect(hrPack.toString()).to.equal('Package: HR Services (inactive)\n- Value (excl. VAT): 1500\n- Value (VAT 20%): 1800');
    });

    it("It should throw an error", function () {
        expect(() => {
            let hrPack = new PaymentPackage('HR Services');
        }).to.throw(Error, 'Value must be a non-negative number');
    });

    it("It should throw an error", function () {
        expect(() => {
            let hrPack = new PaymentPackage('HR Services', 'fefe');
        }).to.throw(Error, 'Value must be a non-negative number');
    });

    it("It should throw an error", function () {
        expect(() => {
            let hrPack = new PaymentPackage('HR Services', -10);
        }).to.throw(Error, 'Value must be a non-negative number');
    });

    it("It should throw an error", function () {
        expect(() => {
            let hrPack = new PaymentPackage('HR Services', -1);
        }).to.throw(Error, 'Value must be a non-negative number');
    });

    it("It should not throw an error", function () {
        let hrPack = new PaymentPackage('HR Services', 0);
        expect(hrPack.value).to.equal(0)
    });

    it("It should throw an error", function () {
        expect(() => {
            let hrPack = new PaymentPackage('', 10);
        }).to.throw(Error, 'Name must be a non-empty string');
    });

    it("It should throw an error", function () {
        expect(() => {
            let hrPack = new PaymentPackage(10);
        }).to.throw(Error, 'Name must be a non-empty string');
    });

    it("It should throw an error", function () {
        expect(() => {
            let hrPack = new PaymentPackage();
        }).to.throw(Error, 'Name must be a non-empty string');
    });

    it("It should throw an error", function () {
        let hrPack = new PaymentPackage('HR Services', 10);
        expect(() => {
            hrPack.VAT = -20;
        }).to.throw(Error, 'VAT must be a non-negative number');
    });

    it("It should throw an error", function () {
        let hrPack = new PaymentPackage('HR Services', 10);
        hrPack.VAT = 0;
        expect(hrPack.VAT).to.equal(0);
    });

    it("It should throw an error", function () {
        let hrPack = new PaymentPackage('HR Services', 10);
        expect(() => {
            hrPack.VAT = -1;
        }).to.throw(Error, 'VAT must be a non-negative number');
    });

    it("It should throw an error", function () {
        let hrPack = new PaymentPackage('HR Services', 10);
        hrPack.VAT = 1;
        expect(hrPack.VAT).to.equal(1);
    });

    it("It should throw an error", function () {
        let hrPack = new PaymentPackage('HR Services', 10);
        expect(() => {
            hrPack.VAT = '';
        }).to.throw(Error, 'VAT must be a non-negative number');
    });

    it("It should throw an error", function () {
        let hrPack = new PaymentPackage('HR Services', 10);
        expect(() => {
            hrPack.active = '';
        }).to.throw(Error, 'Active status must be a boolean');
    });

    it("It should throw an error", function () {
        let hrPack = new PaymentPackage('HR Services', 10);
        expect(() => {
            hrPack.active = null;
        }).to.throw(Error, 'Active status must be a boolean');
    });

    it("It should throw an error", function () {
        let hrPack = new PaymentPackage('HR Services', 10);
        expect(() => {
            hrPack.active = 20;
        }).to.throw(Error, 'Active status must be a boolean');
    });

    it("It should give right result", function () {
        const packages = [
            new PaymentPackage('HR Services', 1500),
            new PaymentPackage('Consultation', 800),
            new PaymentPackage('Partnership Fee', 7000),
        ];
        let result = packages.join('\n');
        expect(result).to.equal(`Package: HR Services\n- Value (excl. VAT): 1500\n- Value (VAT 20%): 1800\nPackage: Consultation\n- Value (excl. VAT): 800\n- Value (VAT 20%): 960\nPackage: Partnership Fee\n- Value (excl. VAT): 7000\n- Value (VAT 20%): 8400`);
    });
});

