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
    const $editForm = $('#formEditBook');

    // Bind menu links.
    $('header#menu > a').on('click', function () {
        let viewId = '#view' + $(this).attr('id').slice(4);
        showView(viewId);
    });

    $('#linkLogout').on('click', logout);
    $('#linkBooks').on('click', listBooks);

    // Bind form submits.
    $registerForm.find('input[type=submit]').on('click', register);
    $loginForm.find('input[type=submit]').on('click', login);
    $createBookForm.find('input[type=submit]').on('click', createBook);

    // Attach AJAX "loading" event listener
    $(document).on({
        ajaxStart: function () {
            $("#loadingBox").show()
        },
        ajaxStop: function () {
            $("#loadingBox").hide()
        }
    });

    function showError(err) {
        $('#errorBox').text(err.message).show();
        setTimeout(function () {
            $('#errorBox').fadeOut();
        }, 3000)
    }

    function showInfo(msg) {
        $('#infoBox').text(msg).show();
        setTimeout(function () {
            $('#infoBox').fadeOut();
        }, 3000)
    }

    // Set personalized greeting.
    if (sessionStorage['username']) {
        $('#loggedInUser').text(`Hello ${sessionStorage['username']}!`);
    }

    // Prevent forms default.
    $("form").submit(function (event) {
        event.preventDefault()
    });

    function request(url, method, headers, data) {
        return $.ajax({
            url: url,
            method: method,
            data: data,
            headers: headers
        })
    }

    function showView(selector) {
        $('main > section').hide();
        $(selector).show();
    }

    function register() {
        const registerUrl = baseUrl + 'user/' + appKey;
        let data = {
            username: $registerForm.find('input[name=username]').val(),
            password: $registerForm.find('input[name=passwd]').val(),
        };
        request(registerUrl, 'POST', appAuth, data)
            .then(saveAuthToken)
            .then(() => showView('#viewHome'))
            .then(() => showInfo('Register successful.'));
    }

    function login() {
        const loginUrl = baseUrl + 'user/' + appKey + '/login';
        let data = {
            username: $loginForm.find('input[name=username]').val(),
            password: $loginForm.find('input[name=passwd]').val(),
        };
        request(loginUrl, 'POST', appAuth, data)
            .then(saveAuthToken)
            .then(() => showView('#viewHome'))
            .then(() => showInfo('Login successful.'));
    }

    function logout() {
        sessionStorage.clear();
        $('#loggedInUser').text('');
        showView('#homeView');
    }

    function saveAuthToken(userInfo) {
        let authToken = userInfo._kmd.authtoken;
        sessionStorage.setItem('authToken', authToken);

        let username = userInfo.username;
        sessionStorage.setItem('username', username);

        let userId = userInfo._id;
        sessionStorage.setItem('userId', userId);

        $('#loggedInUser').text(`Hello ${username}!`)
    }

    function getAuthToken() {
        return {Authorization: 'Kinvey ' + sessionStorage.getItem('authToken')}
    }

    function createBook() {
        const createBookUrl = baseUrl + 'appdata/' + appKey + '/books';
        let data = {
            title: $createBookForm.find('input[name=title]').val(),
            author: $createBookForm.find('input[name=author]').val(),
            description: $createBookForm.find('textarea[name=description]').val(),
        };
        request(createBookUrl, 'POST', getAuthToken(), data)
            .then(showView('#viewHome'));
    }

    function listBooks() {
        const getBooksUrl = baseUrl + 'appdata/' + appKey + '/books';
        request(getBooksUrl, 'GET', getAuthToken())
            .then(displayBooks);
    }

    function displayBooks(books) {

        // Initialize html array with table headers.
        let $bookTable = $('#books').find('table')
            .html(`<tr><th>Title</th><th>Author</th><th>Description</th><th>Actions</th></tr>`);

        if (books.length === 0) {
            $bookTable.append($('<div>').text('No books in list.'));
            return;
        }

        for (let book of books) {
            let links = [];

            // Add Delete & Edit options if user is book's creator.
            if (book._acl.creator === sessionStorage['userId']) {
                let deleteLink = $('<a href="#">[Delete]</a>')
                    .on('click', deleteBook.bind(this, book._id));
                let editLink = $('<a href="#">[Edit]</a>')
                    .on('click', editBook.bind(this, book._id));
                links = [deleteLink, ' ', editLink];
            }

            // Append book info to table.
            $bookTable.append($('<tr>').append(
                $('<td>').text(book.title),
                $('<td>').text(book.author),
                $('<td>').text(book.description),
                $('<td>').append(links)
            ));
        }
    }

    function deleteBook(bookId) {
        let deleteBookUrl = baseUrl + 'appdata/' + appKey + '/books/' + bookId;
        request(deleteBookUrl, 'DELETE', getAuthToken())
            .then(displayBooks);
    }

    function editBook(bookId) {
        let editBookUrl = baseUrl + 'appdata/' + appKey + '/books/' + bookId;
        request(editBookUrl, 'GET', getAuthToken())
            .then(fillBookForm)
            .then(() => showView('#viewEditBook'));
    }

    function fillBookForm(book) {
        $editForm.find('input[name=id]').val(book._id);
        $editForm.find('input[name=title]').val(book.title);
        $editForm.find('input[name=author]').val(book.author);
        $editForm.find('textarea[name=description]').val(book.description);
        $editForm.find('input[type=submit]').on('click', submitEditBookForm);
    }

    function submitEditBookForm() {
        let bookId = $editForm.find('input[name=id]').val();
        let editBookUrl = baseUrl + 'appdata/' + appKey + '/books/' + bookId;
        let data = {
            title: $editForm.find('input[name=title]').val(),
            author: $editForm.find('input[name=author]').val(),
            description: $editForm.find('textarea[name=description]').val()
        };
        request(editBookUrl, 'PUT', getAuthToken(), data)
            .then(listBooks)
            .then(() => showView('#viewBooks'));
    }
}
