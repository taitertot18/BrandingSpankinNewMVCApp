// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#calculate').click(function () {
        // Get the number of hours entered by the user
        var hours = parseFloat($('#Hours').val());

        // Check if the entered value is a positive number
        if (isNaN(hours) || hours <= 0) {
            alert('Please enter a positive number of hours.');
            return;
        }

        // Get the hourly rate
        var rate = 20;

        // Calculate total charge
        var total = hours * rate;

        // Display total
        $('#TotalCost').text('$' + total.toFixed(2));
    });
});

