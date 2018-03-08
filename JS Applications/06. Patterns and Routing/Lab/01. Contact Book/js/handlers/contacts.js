handlers.contacts = function (context) {
    $.get('data.json')
        .then(loadData)
        .then(loadPartials)
        .then(attachEvents);

    function loadData(data) {
        context.contacts = data;
        context.selected = null;
    }

    function loadPartials() {
        context.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs',
            contact: './templates/common/contact.hbs',
            contact_list: './templates/common/contactList.hbs',
            contact_details: './templates/common/contactDetails.hbs',
        }).then(function () {
            this.partial('./templates/contacts.hbs');
        });
    }

    function attachEvents() {
        $('.contact').on('click', target);

        function target() {
            let index = $(this).attr('data-index');
            context.selected = context.contacts[index];
            context.contacts.forEach(c => c.active = false);
            context.contacts[index].active = true;
        }
    }
};