function cars(commandsArr) {
    let objectManager = (function () {
        let objectCollection = {};
        return {
            create: function(args) {
                let [name, parent] = [args[0], args[2]];
                if (parent) {
                    objectCollection[name] = Object.create(objectCollection[parent]);
                } else {
                    objectCollection[name] = {};
                }
            },
            set: ([name, key, value]) => objectCollection[name][key] = value,
            print: function([name]) {
                let obj = objectCollection[name];
                let objProps = [];
                for (let key in obj) {
                    objProps.push(`${key}:${obj[key]}`);
                }

                console.log(objProps.join(', '));
            }
        }
    })();

    for(let commandStr of commandsArr) {
        let args = commandStr.split(' ');
        let command = args.shift();
        objectManager[command](args);
    }
}
