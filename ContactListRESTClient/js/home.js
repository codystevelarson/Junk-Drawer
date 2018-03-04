$(document).ready(function () {
    loadContacts();

    //Add contact button method
    $("#add-button").click(function (event) {

        var haveValidationErrors = checkAndDisplayValiationErrors($('#add-form').find('input'));

        if(haveValidationErrors){
            return false;
        }


        $.ajax({
            type: 'POST',
            url: 'http://localhost:60830/contact',
            data: JSON.stringify({
                firstName: $("#add-first-name").val(),
                lastName: $("#add-last-name").val(),
                company: $("#add-company").val(),
                phone: $("#add-phone").val(),
                email: $("#add-email").val()
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            'dataType': 'json',
            success: function () {
                $("#errorMessages").empty();
                $("#add-first-name").val('');
                $("#add-last-name").val('');
                $("#add-company").val('');
                $("#add-phone").val('');
                $("#add-email").val('');
                loadContacts();
            },
            error: function (data, status) {
                $("#errorMessages")
                    .append($('<li>')
                        .attr({ class: 'list-group-item list-group-item-danger' })
                        .text('Error calling web service. Please try again later'))
                console.log(data);
                console.log(status);
            }
        })

    });

    //Edit contact button method
    $("#edit-button").click(function (event) {

        var haveValidationErrors = checkAndDisplayValiationErrors($('#edit-form').find('input'));

        if(haveValidationErrors){
            return false;
        }

        $.ajax({
            type: 'PUT',
            url: 'http://localhost:60830/contact/' + $("#edit-contact-id").val(),
            data: JSON.stringify({
                contactId: $("#edit-contact-id").val(),
                firstName: $("#edit-first-name").val(),
                lastName: $("#edit-last-name").val(),
                company: $("#edit-company").val(),
                phone: $("#edit-phone").val(),
                email: $("#edit-email").val()
            }),
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            'dataType': 'json',
            success: function () {
                $("#errorMessages").empty();
                hideEditForm();
                loadContacts();
            },
            error: function (data, status) {
                $("#errorMessages")
                    .append($('<li>')
                        .attr({ class: 'list-group-item list-group-item-danger' })
                        .text('Error calling web service. Please try again later'))
                console.log(data);
                console.log(status);
            }
        })
    });
});

/////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////

function loadContacts() {
    clearContactTable();
    var contentRows = $('#contentRows');

    $.ajax({
        type: 'GET',
        url: 'http://localhost:60830/contacts',
        success: function (contactArray) {
            $.each(contactArray, function (index, contact) {
                var name = contact.firstName + ' ' + contact.lastName;
                var company = contact.company;
                var contactId = contact.contactId;

                var row = '<tr>';
                row += '<td>' + name + '</td>';
                row += '<td>' + company + '</td>';
                row += '<td><a onclick="showEditForm(' + contactId + ')">Edit</a></td>';
                row += '<td><a onclick="deleteContact(' + contactId + ')">Delete</a></td>';
                row += '</tr>';

                contentRows.append(row);
            });
        },
        error: function (data, status) {
            $("#errorMessages")
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later'));
            console.log(data);
            console.log(status);
        }
    });
}

function clearContactTable() {
    $('#contentRows').empty();
}

function showEditForm(contactId) {
    $("#errorMessages").empty();

    $.ajax({
        type: 'GET',
        url: 'http://localhost:60830/contact/' + contactId,
        success: function (data, status) {
            $("#edit-first-name").val(data.firstName);
            $("#edit-last-name").val(data.lastName);
            $("#edit-company").val(data.company);
            $("#edit-email").val(data.email);
            $("#edit-phone").val(data.phone);
            $("#edit-contact-id").val(data.contactId);
        },
        error: function (data, status) {
            $("#errorMessages")
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later'));
            console.log(data);
            console.log(status);
        }
    });

    $("#contactTableDiv").hide();
    $("#editFormDiv").show();
}

function hideEditForm() {
    $("#errorMessages").empty();

    $("#edit-first-name").val('');
    $("#edit-last-name").val('');
    $("#edit-company").val('');
    $("#edit-email").val('');
    $("#edit-phone").val('');

    $("#editFormDiv").hide();
    $("#contactTableDiv").show();
}

function deleteContact(contactId) {
    $.ajax({
        type: 'DELETE',
        url: 'http://localhost:60830/contact/' + contactId,
        success: function () {
            loadContacts();
        },
        error: function (data, status) {
            $("#errorMessages")
                .append($('<li>')
                    .attr({ class: 'list-group-item list-group-item-danger' })
                    .text('Error calling web service. Please try again later'));
            console.log(data);
            console.log(status);
        }
    });
}


function checkAndDisplayValiationErrors(input){
    $("#errorMessages").empty();

    var errorMessages = [];

    input.each(function(){
        if(!this.validity.valid){
            var errorField = $('lable[for=' + this.id + ']').text();
            errorMessages.push(errorField + '' + this.validationMessage);
        }
    });

    if (errorMessages.length > 0){
        $.each(errorMessages, function(index, message){
            $('#errorMessages').append($('<li>').attr({class: 'list-group-item list-group-item-danger'}).text(message));
        });
        return true;
    } else {
        return false;
    }
}