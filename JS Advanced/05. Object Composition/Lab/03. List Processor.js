function listProcesses(commandsArr) {
    let processor = (function() {
        let collection = [];

        return {
            add: (str) => collection.push(str),
            remove: (str) => collection = collection.filter(e => e !== str),
            print: () => console.log(collection.join())
        }
    })();

    for (let command of commandsArr) {
        let [cmd, str] = command.split(' ');
        processor[cmd](str);
    }
}
