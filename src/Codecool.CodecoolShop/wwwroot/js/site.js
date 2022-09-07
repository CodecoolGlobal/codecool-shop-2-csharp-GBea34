// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Cart Modal display 
let cart_modal = document.getElementById("cart-modal");
let cart_button = document.getElementById("cart-button");
let span = document.getElementsByClassName("cart-close")[0];

cart_button.onclick = function() {
    cart_modal.style.display = "block";
}

span.onclick = function() {
    cart_modal.style.display = "none";
}

window.onclick = function(event) {
    if (event.target == cart_modal) {
        cart_modal.style.display = "none";
    }
}