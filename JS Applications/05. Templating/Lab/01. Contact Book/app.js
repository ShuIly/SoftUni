$(() => {
    const contactsContent = $('#list').find('.content');
    const detailsContent = $('#details').find('.content');

    const template = {};
    const context = {
        contacts: []
    };

    const contactTempProm = $.get('./templates/contact.html');
    const contactListTempProm = $.get('./templates/contactList.html');
    const contactDetailsTempProm = $.get('./templates/contactDetails.html');

    let templateLoadP = Promise.all([contactTempProm, contactListTempProm, contactDetailsTempProm])
        .then(loadTemplates);

    let dataLoadP = $.get('data.json')
        .then(setContext);

    Promise.all([templateLoadP, dataLoadP])
        .then(displayContacts);

    function loadTemplates([contactTemp, contactListTemp, contactDetailsTemp]) {
        Handlebars.registerPartial('contact', contactTemp);
        template.contactList = Handlebars.compile(contactListTemp);
        template.contactDetails = Handlebars.compile(contactDetailsTemp);
    }

    function setContext(data) {
        context.contacts = data.map(c => {
            c.active = false;
            return c;
        });
    }

    function displayContacts() {
        contactsContent.html(template.contactList(context));
        $('.contact').on('click', setActive);
    }

    function setActive() {
        let index = $(this).attr('data-index');
        context.contacts.forEach(c => c.active = false);
        context.contacts[index].active = true;

        displayActive(index);
        displayContacts();
    }

    function displayActive(index) {
        detailsContent.html(template.contactDetails(context.contacts[index]));
    }
});