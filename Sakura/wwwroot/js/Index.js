$(document).ready(function () {

    console.log("bonjour de la nain rouge ");

    var navigation = $(".navbarInfo");
    navigation.on("click", function () {
        console.log("Clicked: " + $(this).text());
    });

    var navToggle = $(".headerFont");
    var navContent = $(".navbarBasic");
    navToggle.on("click", function () {
        navContent.fadeToggle(500);
    });
});