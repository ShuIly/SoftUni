class PaymentProcessor {
    constructor(options) {
        this.options = {types: ["service", "product", "other"], precision: 2};
        this.setOptions(options);
        this.payments = {};
    }

    validateString(newValue) {
        if (typeof newValue !== 'string') {
            throw new Error('Value must be a non-empty string');
        }

        if (newValue.length === 0) {
            throw new Error('Value must be a non-empty string');
        }
    }

    validateNumber(newValue) {
        if (typeof newValue !== 'number') {
            throw new Error('Value must be a non-negative number');
        }
    }

    registerPayment(id, name, type, value) {
        this.validateString(id);
        this.validateString(name);
        if (this.options.types.indexOf(type) < 0) {
            throw new Error('Invalid type');
        }
        this.validateNumber(value);

        if (this.payments[id] !== undefined) {
            throw new Error('Payment with this ID already exists');
        }

        this.payments[id] = {
            name: name,
            type: type,
            value: value
        }
    }

    deletePayment(id) {
        if (this.payments[id] === undefined) {
            throw Error('ID not found');
        }

        delete this.payments[id];
    }

    get(id) {
        if (this.payments[id] === undefined) {
            throw Error('ID not found');
        }

        let payment = this.payments[id];
        return `Details about payment ID: ${id}\n- Name: ${payment.name}\n- Type: ${payment.type}\n- Value: ${payment.value.toFixed(this.options.precision)}`;
    }

    setOptions(options) {
        if (options !== undefined) {
            if (options.types !== undefined) {
                this.options.types = options.types;
            }

            if (options.precision !== undefined) {
                this.options.precision = options.precision;
            }
        }
    }

    toString() {
        let paymentSum = 0;
        let paymentCount = 0;
        for (let id in this.payments) {
            paymentSum += this.payments[id].value;
            paymentCount++;
        }

        return `Summary:\n- Payments: ${paymentCount}\n- Balance: ${paymentSum.toFixed(this.options.precision)}`;
    }
}

// Initialize processor with default options
const generalPayments = new PaymentProcessor();
generalPayments.registerPayment('0001', 'Microchips', 'product', 15000);
generalPayments.registerPayment('0001', 'Microchips', 'product', 15000);
console.log(generalPayments.toString());
generalPayments.deletePayment('0001');

console.log(generalPayments.toString());

