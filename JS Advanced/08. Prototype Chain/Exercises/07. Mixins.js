function solve() {
    function computerQualityMixin(obj) {
        obj.prototype.getQuality = function () {
            return (this.processorSpeed + this.RAM + this.hardDiskSpace) / 3;
        };

        obj.prototype.isFast = function () {
            return this.processorSpeed > (this.ram / 4);
        };

        obj.prototype.isRoomy = function () {
            return this.hardDiskSpace > Math.floor(this.ram * this.processorSpeed);
        }
    }

    function styleMixin(obj) {
        obj.prototype.isFullSet = function () {
            return this.keyboard.manufacturer === this.monitor.manufacturer;
        };

        obj.prototype.isClassy = function () {
            return this.battery.expectedLife >= 3 &&
                (this.color === 'Silver' || this.color === 'Black') &&
                this.weight < 3;
        };
    }

    return {
        computerQualityMixin,
        styleMixin
    }
}