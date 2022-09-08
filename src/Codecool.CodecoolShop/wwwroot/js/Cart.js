const checkout = {
    button: function () {
        let checkoutButton = document.getElementById("checkout2");
        checkoutButton.addEventListener('click',event => {this.goToCheckout();});
    },
    goToCheckout: function (){
        location.href ="/checkout"
    }
}
checkout.button()