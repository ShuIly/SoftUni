handlers.contacts = function (context) {
    $.get('data.json')
        .then(loadData)
        .then(loadPartials);

    function loadData(data) {
        context.contacts = data;
        context.selected = null;
    }

    function loadPartials() {
        context.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            contact_list: './templates/common/contactList.hbs',
            contact_details: './templates/common/contactList.hbs',
        }).then(function () {
            context.partial('./templates/contacts.hbs')
        });
    }
};