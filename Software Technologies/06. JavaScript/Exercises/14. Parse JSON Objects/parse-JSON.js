function getObjects(args) {
    let objectList = [];
    for (let i = 0; i < args.length; ++i) {
        let obj = JSON.parse(args[i]);
        objectList.push(obj);
    }
    for (let obj of objectList) {
        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Date: ${obj.date}`);
    }
}