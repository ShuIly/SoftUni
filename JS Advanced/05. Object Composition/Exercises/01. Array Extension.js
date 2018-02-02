(function () {
    Array.prototype.last = function () {
        return this[this.length - 1];
    };

    Array.prototype.skip = function (n) {
        if (!scopeIsValid(n, this.length)) return;

        let result = [];
        for (let i = n; i < this.length; ++i) {
            result.push(this[i]);
        }

        return result;
    };

    Array.prototype.take = function (n) {
        if (!scopeIsValid(n, this.length)) return;

        let result = [];
        for (let i = 0; i < n; ++i) {
            result.push(this[i]);
        }

        return result;
    };

    Array.prototype.sum = function () {
        let result = 0;
        for (let num of this) {
            result += num;
        }

        return result;
    };

    Array.prototype.average = function () {
        let sum = this.sum();
        return sum / this.length;
    };

    function scopeIsValid(n, length) {
        return n > 0 && n < length;
    }
})();