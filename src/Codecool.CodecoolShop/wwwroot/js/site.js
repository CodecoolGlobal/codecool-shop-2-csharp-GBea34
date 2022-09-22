import {userActivity} from "./UserActivity.js";


//<p><a href="#">Product 1</a> <span className="price">$15</span></p>
const HtmlFactory = {
    checkoutCart: function (data) {
        let productNum = document.getElementById("count");
        productNum.innerText = data.length();
        let cartTitle = document.getElementById("cart")
        for (let i = 0; i < data.length; i++) {
            let producktInfoContainer = document.createElement("p");
            document.insertAfter(producktInfoContainer, cartTitle);
            let aTag = document.createElement("a");
            producktInfoContainer.appendChild(aTag);
            aTag.innerText = data[i]['Name'];
            let priceSpan = document.createElement("span")
            aTag.appendChild(priceSpan);
            priceSpan.innerText = data[i]['DefaultPrice'];

        }

    },
}

// login form
function Login() {
    document.getElementById('back').style.display = 'block';
    if (document.getElementById('signup').style.display == 'block') {
        document.getElementById('signup').style.display = 'none';
    }
    document.getElementById('login').style.display = 'block';
}

function Signup() {

    document.querySelector("#signupNow").addEventListener("click",()=>{
        if (document.getElementById('login').style.display === 'block') {
        document.getElementById('login').style.display = 'none'
    }
        document.getElementById('signup').style.display = 'block';})
    
}

function exitButtons(){
    document.querySelector("#exit").addEventListener("click", Exit);
    document.querySelector("#exitNow").addEventListener("click", Exit);
}
function Exit() {
    document.getElementById('back').style.display = 'none';
    document.getElementById('login').style.display = 'none';
    document.getElementById('signup').style.display = 'none';
}
Signup();
exitButtons()
loginButtons();
userActivity.regButton();