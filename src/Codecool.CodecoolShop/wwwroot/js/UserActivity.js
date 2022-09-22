import {apiPost} from "./Datahandler.js";

export const userActivity = {
    registration :function () {
        let name = document.querySelector("#registrationName").value;
        let password1= document.querySelector("#password1").value;
        let password2= document.querySelector("#password2").value;
        let email= document.querySelector("#registrationEmail").value;
        if (password1===password2){
            apiPost("Data/registration", {name:name,  email:email ,password:password1}).then(data=>console.log(data))
        }
        else{
            prompt("nemnyert")}
            
    },
    regButton: function (){
        let regButton=document.querySelector("#signUpButton")
        regButton.addEventListener("click", this.registration)
    }
}
