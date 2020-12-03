// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#sidebar").mCustomScrollbar({
        theme: "minimal"
    });

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar, #content').toggleClass('active');
        $('.collapse.in').toggleClass('in');
        $('a[aria-expanded=true]').attr('aria-expanded', 'false');
    });
});

const filters_toggles = document.getElementsByClassName("filters-toggle");
const filters = document.getElementsByClassName("filters");

Array.prototype.forEach.call(filters_toggles, e => {
    e.onclick = () => {
        e.classList.toggle("active");
        Array.prototype.forEach.call(filters, f => {
            f.classList.toggle("active");
        });
    };
});

const checkboxes = document.getElementsByClassName("checkbox");
const navbar_icons = document.getElementsByClassName("fa");

Array.prototype.forEach.call(checkboxes, e => {
    e.onclick = () => {
        e.classList.toggle("active");
    };
});


Array.prototype.forEach.call(navbar_icons, e => {
    e.onclick = () => {
        e.classList.toggle("active");
    };
});