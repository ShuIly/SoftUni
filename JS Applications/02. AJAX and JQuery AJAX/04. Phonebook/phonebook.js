(function () {
    $('#btnLoad').on('click', loadContacts);
    $('#btnCreate').on('click', addContact);
    const phonebook = $('#phonebook');

    function loadContacts() {
        let request = {
            url: 'https://phonebook-5dc35.firebaseio.com/contacts.json',
            success: displayContacts,
            error: e => console.log(e)
        };
        $.ajax(request);
    }

    function displayContacts(data) {
        phonebook.empty();
        for (let contact in data) {
            phonebook.append($(`<li>${data[contact].name}: ${data[contact].phone}</li>`)
                .append($(`<a href="#"> [Delete]</a>`)
                    .on('click', () => deleteContact(contact))));
        }
    }

    function deleteContact(contact) {
        let request = {
            url: `https://phonebook-5dc35.firebaseio.com/contacts/${contact}.json`,
            method: 'DELETE',
            success: loadContacts,
            error: e => console.log(e)
        };
        $.ajax(request);
    }

    function addContact() {
        let data = {
            name: document.getElementById('person').value,
            phone: document.getElementById('phone').value
        };

        let request = {
            url: 'https://phonebook-5dc35.firebaseio.com/contacts.json',
            method: 'POST',
            data: JSON.stringify(data),
            success: loadContacts,
            error: e => console.log(e)
        };
        $.ajax(request);
    }
})()