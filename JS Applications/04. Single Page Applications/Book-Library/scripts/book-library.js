function startApp() {

    // Application constants.
    const appKey = 'kid_Hyug-mgdz';
    const appSecret = 'fbba608930f148678a7c82232e6f161e';
    const baseUrl = 'https://baas.kinvey.com/';
    const appAuth = {
        Authorization: 'Basic ' + btoa(appKey + ':' + appSecret)
    };

    // Form constants.
    const $registerForm = $('#formRegister');
    const $loginForm = $('#formLogin');
    const $createBookForm = $('#formCreateBook');

    // Bind menu links.
    $('header#menu > a').on('click', showView);
    $('#linkLogout').on('click', logout);
    $('#linkBooks').on('click', listBooks);

    // Bind form submits.
    $registerForm.find('input[type=submit]').on('click', register);
    $loginForm.find('input[type=submit]').on('click', login);
    $createBookForm.find('input[type=submit]').on('click', createBook);

    // Prevent forms default.
    $("form").submit(function (event) {
        event.preventDefault()
    });

    function viewHome() {
        showView.call(document.getElementById('linkHome'));
    }

    function request(url, method, headers, data) {
        return $.ajax({
            url: url,
            method: method,
            data: data,
            headers: headers
        })
    }

    function showView() {
        let viewId = $(this).attr('id').slice(4);

        $('main > section').hide();
        $('#view' + viewId).show();
    }

    function register() {
        const registerUrl = baseUrl + 'user/' + appKey;
        let data = {
            username: $registerForm.find('input[name=username]').val(),
            password: $registerForm.find('input[name=passwd]').val(),
        };
        request(registerUrl, 'POST', appAuth, data)
            .then(saveAuthToken)
            .then(viewHome);
    }

    function login() {
        const loginUrl = baseUrl + 'user/' + appKey + '/login';
        let data = {
            username: $loginForm.find('input[name=username]').val(),
            password: $loginForm.find('input[name=passwd]').val(),
        };
        request(loginUrl, 'POST', appAuth, data)
            .then(saveAuthToken)
            .then(viewHome);
    }

    function logout() {
        sessionStorage.clear();
        $('#loggedInUser').text('');
        viewHome();
    }

    function saveAuthToken(userInfo) {
        let authToken = userInfo._kmd.authtoken;
        sessionStorage.setItem('authToken', authToken);

        let username = userInfo.username;
        sessionStorage.setItem('username', username);

        $('#loggedInUser').text(`Hello ${username}!`)
    }

    function getAuthToken() {
        return { Authorization: 'Kinvey ' + sessionStorage.getItem('authToken') }
    }

    function createBook() {
        const createBookUrl = baseUrl + 'appdata/' + appKey + '/books';
        let data = {
            title: $createBookForm.find('input[name=title]').val(),
            author: $createBookForm.find('input[name=author]').val(),
            description: $createBookForm.find('textarea[name=description]').val(),
        };
        request(createBookUrl, 'POST', getAuthToken(), data)
            .then(viewHome);
    }

    function listBooks() {
        $('#books').empty();
        const getBooksUrl = baseUrl + 'appdata/' + appKey + '/books';
        request(getBooksUrl, 'GET', getAuthToken())
            .then(displayBooks);
    }

    function displayBooks(books) {
        
    }
}
