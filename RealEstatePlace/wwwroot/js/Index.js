$(document).ready(function() {
    var theform = $("#the-form");
    theform.hide();

    var button = $("#request-visit");
    button.on("click",
        function() {
            console.log("Requesting a visit");
        });

    var productInfo = $(".product-props li");
    productInfo.on("click",
        function() {
            console.log("You clicked on " + $(this).text());
        });

    var $loginToggle = $("#login-toggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function() {
        $popupForm.toggle(400);
    });
});
