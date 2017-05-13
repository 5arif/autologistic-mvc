$(function () {
    // Closes the sidebar menu
    $("#btnCancel").click(function (e) {
        e.preventDefault();
        $("#sidebar-wrapper").toggleClass("active");
        $('html,body').animate({
            scrollTop: 0
        }, 600);
    });

    // Opens the sidebar menu
    $('.fa-stack.fa-4x.point').click(function (e) {
        e.preventDefault();
        $("#sidebar-wrapper").toggleClass("active");
    });

    // Scrolls to the selected menu item on the page
    $('a[href*="#"]:not([href="#"])').click(function () {
        if ($('#sidebar-wrapper').hasClass('active')) {
            $("#sidebar-wrapper").toggleClass("active");
        }

        if (location.pathname.replace(/^\//, '') === this.pathname.replace(/^\//, '') ||
            location.hostname === this.hostname) {

            var target = $(this.hash);
            target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
            if (target.length) {
                $('html,body').animate({
                    scrollTop: target.offset().top
                }, 600);
                return false;
            }
        }
    });
});