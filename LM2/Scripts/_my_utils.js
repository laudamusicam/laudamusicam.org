
// Handle "data-my-exec-js" attributes
$(document).ready(function () {
    $("[data-my-exec-js]").each(function () {
        eval($(this).attr("data-my-exec-js"));
    });
});