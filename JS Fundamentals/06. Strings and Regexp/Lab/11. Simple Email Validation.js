function isEmailValid(email) {
    let regex = /^[a-zA-Z\d]*@[a-z]+\.[a-z]+$/;
    return regex.test(email) ? 'Valid' : 'Invalid';
}