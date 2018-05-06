$(document).ready(function () {
    Content.setInputValueToRadio($('#other'));

    $('#User_Phone').mask("+375 (99) 999-99-99");
});

Content = {
    setInputValueToRadio: function (input) {
        $(input).change(function () {
            var radio = $(this).closest('.radio').find("input[type='radio']");
            $(radio).val($(this).val());
        });
    }      
}