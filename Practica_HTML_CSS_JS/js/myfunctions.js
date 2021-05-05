$(document).ready(function () {
    $("#formularioContacto").submit(function (e) {
       e.preventDefault();
        if (($("#txtName.form-control").val().trim().length == 0)){
            $('#lblValName').css("color", "red").text(' Complete este campo.');
            $('#txtName.form-control').css("border-color", "red").focus();
        }
        else {
            $('#lblValName').text('');
            $('#txtName.form-control').removeAttr( 'style' );
        }
        if ($("#txtLastName.form-control").val().trim().length == 0) {
            $('#lblValLastN').css("color", "red").text(' Complete este campo.');
            $('#txtLastName.form-control').css("border-color", "red").focus();
        }
        else {
            $('#lblValLastN').text('');
            $('#txtLastName.form-control').removeAttr( 'style' );
        }
    });
});

$(document).ready(function () {
    $('#btnLimpiar').click(function () {
        $(':input').val('').prop("checked", false).removeAttr( 'style' );
        $('.lblerror').text('');
    });
});
