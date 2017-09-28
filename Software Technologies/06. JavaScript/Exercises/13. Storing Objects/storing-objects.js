function getObjects(args) {
    let objectList = [];
    for (let i = 0; i < args.length; ++i) {
        let inputTokens = args[i].split(' -> ');
        let name = inputTokens[0];
        let age = Number(inputTokens[1]);
        let grade = Number(inputTokens[2]);
        objectList.push({
            name: name,
            age: age,
            grade: grade
        })
    }
    for (let obj of objectList) {
        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Grade: ${obj.grade.toFixed(2)}`);
    }
}