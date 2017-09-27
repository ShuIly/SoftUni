function getObjects(args) {
    let object = {};
    for (let i = 0; i < args.length; ++i) {
        let inputTokens = args.split(' -> ');
        let property = inputTokens[0];
        let value = inputTokens[1];
        object[property] = value;
    }
    console.log(JSON.stringify(object));
}