function validate(obj) {
    if (!obj.hasOwnProperty('method') || obj.method !== 'GET' && obj.method !== 'POST' &&
        obj.method !== 'DELETE' && obj.method !== 'CONNECT') {
        throw new Error('Invalid request header: Invalid Method');
    }
    if (!obj.hasOwnProperty('uri') || !obj.uri.match(/^[A-Za-z0-9.\/-]+$/)) {
        throw new Error('Invalid request header: Invalid URI');
    }
    if (!obj.hasOwnProperty('version') || obj.version !== 'HTTP/0.9' && obj.version !== 'HTTP/1.0' &&
        obj.version !== 'HTTP/1.1' && obj.version !== 'HTTP/2.0') {
        throw new Error('Invalid request header: Invalid Version');
    }
    if (!obj.hasOwnProperty('message') || obj.message.match(/[><\\&'"]/)) {
        throw new Error('Invalid request header: Invalid Message');
    }

    return obj;
}

module.exports = { validate };

// console.log(validate({
//     method: 'GET',
//     uri: 'svn.public.catalog',
//     version: 'HTTP/1.1',
//     message: ''
// }));
//
// console.log(validate({
//     method: 'OPTIONS',
//     uri: 'git.master',
//     version: 'HTTP/1.1',
//     message: '-recursive'
// }));
//
// console.log(validate({
//     method: 'POST',
//     uri: 'home.bash',
//     message: 'rm -rf /*'
// }));
