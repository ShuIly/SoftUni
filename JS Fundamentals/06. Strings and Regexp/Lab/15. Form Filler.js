function formFiller(username, email, number, formArr) {
    let userRegex = /<![A-Za-z]+?!>/;
    let emailRegex = /<@[A-Za-z]+?@>/;
    let numRegex = /<\+[A-Za-z]+?\+>/;

    for (let formStr of formArr) {
        formStr = formStr.replace(userRegex, username);
        formStr = formStr.replace(emailRegex, email);
        formStr = formStr.replace(numRegex, number);

        console.log(formStr);
    }
}
