const handlers = {
    simple: function (context, endpoint) {
        context.loadPartials({
            header: './templates/common/header.hbs',
            footer: './templates/common/footer.hbs'
        }).then(function () {
            this.partial(`./templates/${endpoint}`)
        });
    }
};

$(() => {
    let app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        this.get('index.html', function () {
            handlers.simple(this, 'welcome.hbs')
        });

        this.get('#/profile', function () {
            handlers.simple(this, 'profile.hbs')
        });

        this.get('#/register', function () {
            handlers.simple(this, 'register.hbs')
        });

        this.get('#/contacts', handlers.contacts);

        this.get('#/login', function () {
            handlers.simple(this, 'login.hbs')
        });

    }).run();
});