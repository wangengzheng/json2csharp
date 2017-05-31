$("#inputform").submit(function (event) {
   event.preventDefault();
    var $form = $(this),
    url = $form.attr('action');
    var posting = $.post(url, {
        Example: $('#InputJson').val(),
        UsePascalCase: $('#InputUsePascalCase').is(":checked"),
        UseProperties: $('#InputUseProperties').is(":checked")
    });
    posting.done(function (data) {
        $("#output").html(data.result);
        $('pre code').each(function (i, block) {
            hljs.highlightBlock(block);
        });
    });
});
