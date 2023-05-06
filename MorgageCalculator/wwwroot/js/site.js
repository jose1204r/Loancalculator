// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#reset').click(function () {
        alert("Are you sure want to reset data!")
        
    });
});



$("#clearButton").click(function () {
    $("#textbox1").val("");
});