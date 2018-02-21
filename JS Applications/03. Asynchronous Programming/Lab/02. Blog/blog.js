function attachEvents() {
    // Attach events to buttons.
    $('#btnLoadPosts').on('click', loadPosts);
    $('#btnViewPost').on('click', selectPost);

    // Application constants.
    const baseUrl = 'https://baas.kinvey.com/appdata/kid_B1o4e25wz/';
    const user = 'shully';
    const pass = '123';

    function request(endpoint) {
        return $.ajax({
            url: baseUrl + endpoint,
            headers: {
                Authorization: 'Basic ' + btoa(user + ':' + pass)
            }
        });
    }

    function loadPosts() {
        request('posts')
            .then(fillSelect)
            .catch(reason => console.log(reason));
    }

    function fillSelect(posts) {
        let select = $('#posts').empty();
        let optionsHtml = '';
        for (let post of posts) {
            optionsHtml += `<option value="${post._id}">${post.title}</option>`;
        }

        select.html(optionsHtml);
    }

    function selectPost() {
        let postId = $('#posts').find('option:selected').val();

        let postPromise = request('posts/' + postId);
        let commentsPromise = request(`comments/?query={"postId":"${postId}"}`);

        Promise.all([postPromise, commentsPromise])
            .then(displayPostAndComments)
            .catch((e) => console.log(e));
    }

    function displayPostAndComments([post, comments]) {
        $('#post-title').text(post.title);
        $('#post-body').empty().append($(`<li>${post.body}</li>`));

        let list = $('#post-comments').empty();
        let output = '';
        for (let comment of comments) {
            output += `<li>${comment.text}</li>`;
        }

        list.append(output);
    }
}