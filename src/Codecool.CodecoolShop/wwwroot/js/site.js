// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

let checked = true;
const checkout = {
    button: function () {
        let checkoutButton = document.getElementById("checkout");
        checkoutButton.addEventListener('click',this.goToCheckout);
    },
    goToCheckout: function (){
        location.href ="/product/checkout"
    },
    checkBox: function(){ 
        let checkBox = document.getElementById("check")
        checkBox.addEventListener("click", HtmlFactory.chekBox)
        
    }
}
let fetch = {
    dataHandler:async function (route) {
        const response = await fetch(route);
        const data = await response.json();
        if (data.NewsList.length === 0) {
            return null;
        }
        return data.NewsList;
    },
    
    getCartList:function (){
        
    }
}
//<p><a href="#">Product 1</a> <span className="price">$15</span></p>
const HtmlFactory = {
    chekBox: function (){
        checked=!checked;
        let addressContainer= document.getElementsByClassName("row")[1];
        if (!checked){
            
            let shippingAdressForm = document.createElement('div');
            shippingAdressForm.setAttribute("id", "Shipping")
            shippingAdressForm.setAttribute('class', 'col-25')
            shippingAdressForm.innerHTML= `<h3>Shipping Address</h3>
                <label htmlFor="fname"><i class="fa fa-user"></i> Full Name</label>
                <input type="text" id="Shipfname" name="firstname" placeholder="John M. Doe">
                    <label htmlFor="email"><i class="fa fa-envelope"></i> Email</label>
                    <input type="text" id="Shipemail" name="email" placeholder="john@example.com">
                        <label htmlFor="adr"><i class="fa fa-address-card-o"></i> Address</label>
                        <input type="text" id="Shipadr" name="address" placeholder="542 W. 15th Street">
                            <label htmlFor="city"><i class="fa fa-institution"></i> City</label>
                            <input type="text" id="Shipcity" name="city" placeholder="New York">

                                <div class="row">
                                    <div class="col-50">
                                        <label htmlFor="state">State</label>
                                        <input type="text" id="Shipstate" name="state" placeholder="NY">
                                    </div>
                                    <div class="col-50">
                                        <label htmlFor="zip">Zip</label>
                                        <input type="text" id="Shipzip" name="zip" placeholder="10001">
                                    </div>
                                </div>`
            addressContainer.insertBefore(shippingAdressForm, addressContainer.firstChild)
            
        }else{
            let shipping = document.getElementById("Shipping")
            shipping.remove();
        }
        
        
    }
}

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
checkout.button()
checkout.checkBox()