function loadCommits() {
    const commitsList = $('#commits');

    let username = document.getElementById('username').value;
    let repo = document.getElementById('repo').value;

    $.get(`https://api.github.com/repos/${username}/${repo}/commits`)
        .then(displayCommits)
        .catch(displayError);

    function displayCommits(commits) {
        commitsList.empty();
        for (let commitObj of commits) {
            console.log(commitObj.commit + '<-');
            let name = commitObj.commit.author.name;
            let message = commitObj.commit.message;
            commitsList.append($(`<li>${name}: ${message}</li>`));
        }
    }

    function displayError(error) {
        commitsList.empty();
        commitsList.append($('<li>').text(`Error: ${error.status} (${error.statusText})`));
    }
}