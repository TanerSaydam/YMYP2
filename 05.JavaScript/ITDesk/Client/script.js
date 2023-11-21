const rootEl = document.getElementById("root");

function gotoLogin(){
    rootEl.innerHTML = "<h1>Login Page</h1>";
}

function gotoRegister(){
    rootEl.innerHTML = "<h1>Register Page</h1>";
}


function gotoTicketDetail(){
    rootEl.innerHTML = "<h1>Ticket Detail Page</h1>";
}

function gotoHome(){
    rootEl.innerHTML = "<h1>Home Page</h1>";
}

function checkValidation(e){
    const isValid = e.target.validity.valid;

    if(!isValid){
        e.target.className = "form-control is-invalid";
        const errorMessage = e.target.validationMessage;

        const divEl =document.querySelector("#" + e.target.id + " + div");
        divEl.innerHTML =errorMessage;
    }else{
        e.target.className = "form-control is-valid"
    }
}

function checkValidationForPassword(e){
    const ulEl = document.querySelector(`#${e.target.id} + ul`);
    ulEl.style.display = "block";


    const value = e.target.value;

    const min6LengthLiEl = document.getElementById("min6Length");

    min6LengthLiEl.className = value.length < 6 ? "text-danger" : "text-success";
}