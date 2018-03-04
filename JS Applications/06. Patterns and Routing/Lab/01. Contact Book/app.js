const handlers = {};

$(() => {
    let app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        this.get('index.html', function () {
            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/welcome.hbs')
            });
        });

        this.get('#/profile', function () {
            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs',
            }).then(function () {
                this.partial('./templates/profile.hbs')
            });
        });

        this.get('#/register', function () {
            this.loadPartials({
                header: './templates/common/header.hbs',
                footer: './templates/common/footer.hbs'
            }).then(function () {
                this.partial('./templates/register.hbs')
            });
        });

        this.get('#/contacts', handlers.contacts);
    }).run();
});