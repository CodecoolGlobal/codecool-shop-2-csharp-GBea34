
let checked = true;
const checkout = {
    button: function () {
        let checkoutButton = document.getElementById("checkout");
        checkoutButton.addEventListener('click',this.checkout);
    },
    checkout: function (){
        location.href ="/checkout"
    }
}
