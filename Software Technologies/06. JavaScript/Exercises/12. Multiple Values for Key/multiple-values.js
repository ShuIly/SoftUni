function getMultKeys(args) {
    let kvpLength = args.length - 1;
    let dict = {};
    for (let i = 0; i < kvpLength; ++i) {
        let inputTokens = args[i].split(' ');
        let key = inputTokens[0];
        let value = inputTokens[1];
        if (key in dict)
            dict[key].push(value);
        else
            dict[key] = [value];
    }
    let searchedKey = args[args.length - 1];
    if (dict[searchedKey] === undefined)
        console.log('None');
    else
        for (let value of dict[searchedKey])
            console.log(value);
}