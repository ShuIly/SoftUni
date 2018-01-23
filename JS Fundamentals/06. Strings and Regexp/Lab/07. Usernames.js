function getUsernames(mailArr) {
    let users = [];
    for (let email of mailArr) {
        let tokens = email.split('@');
        let username = tokens[0] + '.';
        let domain = tokens[1];

        domain.split('.').forEach(e => username += e[0]);
        users.push(username);
    }

    return users.join(', ');
}
