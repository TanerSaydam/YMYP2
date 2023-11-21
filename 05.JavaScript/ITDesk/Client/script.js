const rootEl = document.getElementById("root");
gotoHome();

function gotoLogin(){
    rootEl.innerHTML = `
    <div class="d-flex justify-content-center align-items-center" style="height: 60vh;">
            <div class="col-lg-5 col-12">
                <div class="card">
                    <div class="card-header text-center">
                        <h1>Login Page</h1>
                        <p>Giriş yapmak için bilgilerinizi girin</p>
                    </div>
                    <div class="card-body">
                        <div class="form-group">
                            <label for="userNameOrEmail">
                                User Name or Email
                            </label>
                            <input type="text" class="form-control" placeholder="jhondoe" id="userNameOrEmail" onkeyup="checkValidation(event)" required minlength="3">
                            <div class="invalid-feedback"></div>
                        </div>
                        <div class="form-group mt-2">
                            <label for="password">
                                Password
                            </label>
                            <input type="password" class="form-control" placeholder="******" id="password" onkeyup="checkValidationForPassword(event)" required minlength="6">
                            <ul style="display: none;">
                                <li class="text-danger" id="min6Length">
                                    6 karakter uzunluğunda olmalıdır
                                </li>
                                <li class="text-danger" id="upperCase">
                                    Büyük harf içermelidir
                                </li>
                                <li class="text-danger" id="lowerCase">
                                    Küçük harf içermelidir
                                </li>
                                <li class="text-danger" id="number">
                                   Rakam içermelisin
                                </li>
                                <li class="text-danger" id="specialCharacter">
                                    Özel karakter içermelidir
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="card-header">
                        <button onclick="login()" class="btn btn-dark w-100">
                            Giriş Yap
                        </button>
                        <a href="" class="mt-1" style="float: right;">
                            Ücretsiz kaydolmak için buraya tıklayın
                        </a>
                    </div>
                </div>
            </div>
        </div>
        `
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
    e.target.className = "form-control is-invalid";
    checkValidationForPassword2(e.target.value);
}

function checkValidationForPassword2(value){
    const ulEl = document.querySelector(`#password + ul`);
    ulEl.style.display = "block";

    const validation = {
        min6Length: false,
        upperCase: false,
        lowerCase: false,
        number: false,
        specialCharacter: false
    };
    
    const min6LengthLiEl = document.getElementById("min6Length");   
    min6LengthLiEl.className = isTrueReturnSuccessOrDanger(value.length >= 6);

    const upperCaseLiEl = document.getElementById("upperCase");
    upperCaseLiEl.className = isTrueReturnSuccessOrDanger(/[A-Z]/.test(value));    

    const lowerCaseLiEl = document.getElementById("lowerCase");
    lowerCaseLiEl.className = isTrueReturnSuccessOrDanger(/[a-z]/.test(value));
    
    const numberLiEl = document.getElementById("number");
    numberLiEl.className = isTrueReturnSuccessOrDanger(/[0-9]/.test(value));

    const specialCharacterLiEl =document.getElementById("specialCharacter");
    specialCharacterLiEl.className = isTrueReturnSuccessOrDanger(/[^\w\s]/.test(value));
    
    validation.min6Length = value.length >= 6;
    validation.upperCase = /[A-Z]/.test(value);
    validation.lowerCase = /[a-z]/.test(value);
    validation.number = /[0-9]/.test(value);
    validation.specialCharacter = /[^\w\s]/.test(value);

    for(let i in validation){        
        if(!validation[i]) return;
    }

    ulEl.style.display = "none";
    document.getElementById("password").className = "form-control is-valid";
}

function isTrueReturnSuccessOrDanger(expression){
    if(expression) return "text-success"

    return "text-danger"
}

function login(){
    const userNameOrEmailEl = document.getElementById("userNameOrEmail");
    const userNameOrEmailIsValid = userNameOrEmail.validity.valid;
    
    const passwordEl = document.getElementById("password");
    const passwordIsValid = passwordEl.validity.valid;

    if(!userNameOrEmailIsValid){
        userNameOrEmailEl.className = "form-control is-invalid";
        document.querySelector(`#userNameOrEmail + div`).innerHTML = userNameOrEmailEl.validationMessage;
    }

    if(!passwordIsValid){
        passwordEl.className = "form-control is-invalid";
        checkValidationForPassword2(passwordEl.value);
    }

    if(userNameOrEmailIsValid && passwordIsValid){
        //login işlemi
    }

}