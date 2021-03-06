﻿$("#inputform").submit(function (event) {
    event.preventDefault();
    var $form = $(this),
        url = $form.attr('action');
    var posting = $.post(url, {
        Example: $('#InputJson').val(),
        UsePascalCase: $('#InputUsePascalCase').is(":checked"),
        UseProperties: $('#InputUseProperties').is(":checked")
    });
    posting.done(function (data) {
        $("#outputContainer").show();
        $("#output").html(data.result);
        $("#error").hide();
        $('pre code').each(function (i, block) {
            hljs.highlightBlock(block);
        });
    });

    posting.fail(function (data)
    {
        $("#outputContainer").hide();
        $("#error").show();
    });
});


// see https://stackoverflow.com/questions/22581345/click-button-copy-to-clipboard-using-jquery
function copyToClipboard(element) {
    var $temp = $("<input>");
    $("body").append($temp);
    $temp.val($(element).text()).select();
    document.execCommand("copy");
    $temp.remove();
};