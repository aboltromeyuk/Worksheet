$(document).ready(function () {
    Content.setInputValueToRadio($('#other'));    
});

Content = {
    setInputValueToRadio: function (input) {
        $(input).change(function () {
            var radio = $(this).closest('.radio').find("input[type='radio']");
            $(radio).val($(this).val());
        });
    }
}