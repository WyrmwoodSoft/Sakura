$(document).ready(function () {

    console.log("Welcome to Wyrmwood Gaming!");

    var button = document.getElementById("testButton");
    button.addEventListener("click", function () {
        console.log("test click");
    });

    var navigation = $(".navbarInfo li");
    navigation.on("click", function () {
        console.log("Clicked: " + $(this).text());
    });
});