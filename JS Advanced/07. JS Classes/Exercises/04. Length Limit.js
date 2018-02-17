class Stringer {
    constructor(string, length) {
        this.string = string;
        this.length = length;
    }

    get string() {
        return this._string;
    }

    set string(value) {
        this._string = value;
    }

    get length() {
        return this._length;
    }

    set length(value) {
        if (value < 0) value = 0;
        this._length = value;
    }

    increase(length) {
        this.length += length;
    }

    decrease(length) {
        this.length -= length;
    }

    toString() {
        if (this.length === 0) {
            return '...';
        }

        if (this.length < this.string.length) {
            return this.string.substring(0, this.length) + '...';
        }

        return this.string;
    }
}
