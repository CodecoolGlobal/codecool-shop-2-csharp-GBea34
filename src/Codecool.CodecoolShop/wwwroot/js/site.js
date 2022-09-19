let checked = true;
const checkout = {
    checkBox: function () {
        let checkBox = document.getElementById("check")
        checkBox.addEventListener("click", HtmlFactory.chekBox)

    },
    payButton :function (event){
       
        let button= document.getElementById("buuu")
        button.addEventListener("click", ()=>window.location.href ="/product/Thanks")
}

}
//<p><a href="#">Product 1</a> <span className="price">$15</span></p>
const HtmlFactory = {
    checkoutCart: function (data){
        let productNum = document.getElementById("count");
        productNum.innerText=data.length();
        let cartTitle=document.getElementById("cart")
        for (let i=0;i<data.length; i++){
            let producktInfoContainer=document.createElement("p");
            document.insertAfter(producktInfoContainer,cartTitle);
            let aTag= document.createElement("a");
            producktInfoContainer.appendChild(aTag);
            aTag.innerText=data[i]['Name'];
            let priceSpan= document.createElement("span")
            aTag.appendChild(priceSpan);
            priceSpan.innerText=data[i]['DefaultPrice'];
            
        }
        
    },
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


checkout.payButton()
checkout.checkBox()
