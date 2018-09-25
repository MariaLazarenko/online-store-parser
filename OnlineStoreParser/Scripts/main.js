$(document).ready(() => {

    //Single product gallery
    let imgs = $("#prod-gallery img");
    $("#main-img").attr("src", $(imgs[0]).attr("src"));
    console.log($(imgs[0]).attr("src"));

    $("#prod-gallery img").on("click", (e) => {
        $("#main-img").attr("src", $(e.target).attr("src"));
    });


    // Preloader
    $("div[id$=dvProgress]").fadeOut("fast");


});