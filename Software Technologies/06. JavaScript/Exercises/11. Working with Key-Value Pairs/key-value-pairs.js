function getKey(args) {
    let kvpLength = args.length - 1;
    let dict = {};
    for (let i = 0; i < kvpLength; ++i) {
        let inputTokens = args[i].split(' ');
        let key = inputTokens[0];
        let value = inputTokens[1];
        dict[key] = value;
    }
    let searchedKey = args[args.length - 1];
    if (dict[searchedKey] === undefined)
        console.log('None');
    else
        console.log(dict[searchedKey]);
}