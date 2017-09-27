function addRemoveElements(args) {
    let arr = [];
    for (let i = 0; i < args.length; ++i) {
        let inputTokens = args[i].split(' ');
        let command = inputTokens[0];
        let num = Number(inputTokens[1]);
        switch (command) {
            case 'add':
                arr.push(num);
                break;
            case 'remove':
                arr.splice(num, 1);
                break;
        }
    }
    for (let num of arr) {
        console.log(num);
    }
}