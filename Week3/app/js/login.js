function initializeLogin() {

    $('#error').hide();

    $('#submit-btn').click(function(event) {
         if (validateLogin()) {
            alert('Submitting login info');
         }
    });
}

function validateLogin() {
    if ($('#username').val().length == 0) {
        displayError('Please enter a username');
        return false;
    }
    if ($('#password').val().length == 0) {
        displayError('Please enter a password');
        return false;
    }
    return true;
}

function displayError(error) {
    $('#error').text(error);
    $('#error').show();
}