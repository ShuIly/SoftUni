function getObjects(args) {
    let object = {};
    for (let i = 0; i < args.length; ++i) {
        let inputTokens = args[i].split(' -> ');
        let property = inputTokens[0];
        let value = inputTokens[1];
        if (isNaN(value))
            object[property] = value;
        else
            object[property] = Number(value);
    }
    console.log(JSON.stringify(object));
}