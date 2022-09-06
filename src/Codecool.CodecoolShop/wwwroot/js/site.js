const { Button } = require("../lib/bootstrap/dist/js/bootstrap")

chekout = {
    button: function () {
        let checkoutButton = document.getElementById("checkout");
        checkoutButton.addEventListener('click',this.checkout);
    },
    checkout: function (){
        location.href ="/checkout"
    }
}
