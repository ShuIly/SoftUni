function processComands(commands) {

    let processor = (function () {
        let text = '';
        return {
            append: (str) => text += str,
            removeStart: (n) => text = text.slice(n),
            removeEnd: (n) => text = text.slice(0, text.length - n),
            print: () => console.log(text)
        }
    })();

    for (let command of commands) {
        let [name, args] = command.split(' ');
        processor[name](args);
    }
}
