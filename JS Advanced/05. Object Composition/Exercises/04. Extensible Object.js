function getExtensibleObj() {
    return {
        extend: function (template) {
            for (let prop of Object.keys(template)) {
                if (typeof template[prop] === 'function') {
                    Object.getPrototypeOf(this)[prop] = template[prop];
                } else {
                    this[prop] = template[prop];
                }
            }
        }
    }
}
