function validate() {
    $('#company').on('change', toggleCompanyDisplay);

    $('#submit').on('click', submitForm);

    function submitForm(ev) {
        ev.preventDefault();

        let usernameRegex = /^[a-zA-Z0-9]{3,20}$/;
        let passwordRegex = /^\w{5,15}$/;
        let emailRegex = /@.*\./;
        let companyNumberRegex = /^[1-9]{1}[0-9]{3}$/;

        let allFieldsValid = true;

        validateInput($('#username'), usernameRegex);
        validateInput($('#email'), emailRegex);

        let password = $('#password');
        let confirmPassword = $('#confirm-password');

        validateInput(password, passwordRegex);

        if(confirmPassword.val() === password.val() && passwordRegex.test(confirmPassword.val())){
            $('#confirm-password').css('border', 'none');
        } else {
            $('#confirm-password').css('border-color', 'red');
            allFieldsValid = false;
        }

        if($('#company').is(':checked')){
            validateInput($('#companyNumber'), companyNumberRegex);
        }

        function validateInput(input, regex) {
            if(regex.test(input.val())) {
                input.css('border', 'none');
            } else {
                input.css('border-color', 'red');
                allFieldsValid = false;
            }
        }

        if(allFieldsValid){
            $('#valid').css('display', 'block');
        } else {
            $('#valid').css('display', 'none');
        }

    }

    function toggleCompanyDisplay() {
        if($(this).is(':checked')){
            $('#companyInfo').css('display', 'block');
        } else {
            $('#companyInfo').css('display', 'none')
        }
    }
}