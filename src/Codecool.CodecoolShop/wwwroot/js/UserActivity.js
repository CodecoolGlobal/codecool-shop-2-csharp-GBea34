import {apiPost} from "./Datahandler.js";


 function showLoggedIn(email) {
    apiPost("Data/GetNameByEmail", {email: email}).then(data => {
        window.sessionStorage.setItem("name", data["name"]);
        Exit();
        let login = document.querySelector("#logNow");
        login.innerText = `${data["Name"]} Logout`;
    })


}
function Exit() {
    document.getElementById('back').style.display = 'none';
    document.getElementById('login').style.display = 'none';
    document.getElementById('signup').style.display = 'none';
}
export const userActivity = {
    registration: function () {
        let name = document.querySelector("#registrationName").value;
        let password1 = document.querySelector("#password1").value;
        let password2 = document.querySelector("#password2").value;
        let email = document.querySelector("#registrationEmail").value;
        if (password1 === password2) {
            apiPost("Data/Registration", {
                name: name,
                email: email,
                password: password1
            }).then(data => console.log(data))
        } else {
            prompt("nemnyert")
        }

    },
    regButton: function () {
        let regButton = document.querySelector("#signUpButton")
        regButton.addEventListener("click", this.registration)
    },
    login: function () {
        let email = document.querySelector("#loginEmail").value;
        let password = document.querySelector("#loginPassword").value;
        apiPost("Data/Login", {email: email, password: password}).then(data => {
            console.log(data)
            if (data) {
                showLoggedIn(email);
            }
        })
    },
    loginbutton: function () {
        let logButton = document.querySelector("#loginButton");
        logButton.addEventListener("click", this.login)
    }

    
}
