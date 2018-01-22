function addRemoveElements(input) {
    let arr = [];
    for (let i = 0; i < input.length; ++i) {
        if (input[i] === 'add') {
            arr.push(i + 1);
        } else if (input[i] === 'remove') {
            arr.pop();
        }
    }

    return arr.length > 0 ? arr.join('\n') : 'Empty';
}