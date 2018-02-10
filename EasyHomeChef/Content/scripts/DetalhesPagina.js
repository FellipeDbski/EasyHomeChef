$(document).ready(function () {
    $('.menu-link').bigSlide();
});

jQuery(document).ready(function ($) {
    $(".scroll").click(function (event) {
        event.preventDefault();
        $('html,body').animate({ scrollTop: $(this.hash).offset().top }, 900);
    });
});

jQuery(function ($) {
    $(".swipebox").swipebox();
});