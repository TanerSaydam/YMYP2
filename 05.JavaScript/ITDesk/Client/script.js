const rootEl = document.getElementById("root");
gotoHome();

function gotoLogin() {
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
                        <a onclick="gotoRegister()" class="mt-1" style="float: right;">
                            Ücretsiz kaydolmak için buraya tıklayın
                        </a>
                    </div>
                </div>
            </div>
        </div>
        `
}

function gotoRegister() {
    rootEl.innerHTML = `
    <div class="d-flex justify-content-center align-items-center" style="height: 60vh;">
    <div class="col-lg-5 col-12">
        <div class="card">
            <div class="card-header text-center">
                <h1>Register Page</h1>
                <p>Kayıt olmak için aşağıdaki bilgileri doldurun</p>
            </div>
            <div class="card-body">
                <div class="form-group">
                    <label for="name">
                        Name
                    </label>
                    <input type="text" class="form-control" placeholder="jhon" id="name" onkeyup="checkValidation(event)" required minlength="3" autocomplete="off">
                    <div class="invalid-feedback"></div>
                </div>
                <div class="form-group mt-2">
                    <label for="lastName">
                        Last Name
                    </label>
                    <input type="text" class="form-control" placeholder="doe" id="lastName" onkeyup="checkValidation(event)" required minlength="3" autocomplete="off">
                    <div class="invalid-feedback"></div>
                </div>
                <div class="form-group mt-2">
                    <label for="userName">
                        Username
                    </label>
                    <input type="text" class="form-control" placeholder="jhon" id="userName" onkeyup="checkValidation(event)" required minlength="3" autocomplete="off">
                    <div class="invalid-feedback"></div>
                </div>
                <div class="form-group mt-2">
                    <label for="email">
                        Email
                    </label>
                    <input type="email" class="form-control" placeholder="jhon@doe.com" id="email" onkeyup="checkValidation(event)" required minlength="3" email autocomplete="off">
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
                <button onclick="register()" class="btn btn-dark w-100">
                    Kayıt Ol
                </button>
                <a onclick="gotoLogin()" class="mt-1" style="float: right;">
                    Zaten hesabınız var mı?
                </a>
            </div>
        </div>
    </div>
</div>`
}

function gotoTicketDetail() {
    if (checkAuthentication()) {
        rootEl.innerHTML = "<h1>Ticket Detail Page</h1>";
    }
}

async function gotoHome() {
    if (checkAuthentication()) {
        const localStorageResponseString = localStorage.getItem("response");
        const localStorageResponse = JSON.parse(localStorageResponseString);
        const userId = localStorageResponse.userId;

        const response = await axios.get("https://localhost:7079/api/Tickets/GetAll/" + userId)
        
        let text = "";

        for(let index in response.data){
            const data = response.data[index]
            text += `
                <tr>
                    <td>${+index + 1}</td>
                    <td>${data.subject}</td>
                    <td>${data.isUrgent}</td>
                    <td>${data.createdDate}</td>
                    <td>
                        <select onchange="changeTicketStatus('${data.id}', event)" class="form-control">
                            ${data.status === "Open"}
                            <option ${data.status === "Open" ? "selected" : ""}>Open</option>
                            <option ${data.status === "Closed" ? "selected" : ""}>Closed</option>
                        </select>
                    </td>
                </tr>
            `
        }

        rootEl.innerHTML = `
        <h1>ITDesk Home Page</h1>
        <div class="mt-2">
                <h3>New Task Form</h3>
                <div>
                    <div class="form-control">
                    Subject
                    <input id="subject" class="form-control mt-1" style="width:250px;" type="text">
                    </div>

                    <div class="form-control mt-1">
                    IsUrgent
                    <select id="isUrgent" class="form-control" style="width:150px;">
                        <option>No Urgent</option>
                        <option>Normal</option>
                        <option>Urgent</option>
                    </select>
                    </div>

                    <div class="form-control mt-1">
                    <button onclick="createTicket()" class="btn btn-primary">Create a New Task</button>
                    </div>
                </div>
        </div>
        <hr>
        <table class="table table-hover table-bordered mt-2">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Subject</th>
                    <th>IsUrgent</th>
                    <th>Created Date</th>
                    <th>Status</th>
                </tr>
            </thead>
            <tbody>
                ${text}
            </tbody>
        </table>`;
    }
}

async function createTicket(){

    const subjectEl = document.getElementById("subject");
    const isUrgentEl = document.getElementById("isUrgent");
    const localStorageResponseString = localStorage.getItem("response");
    const localStorageResponse = JSON.parse(localStorageResponseString);
    const userId = localStorageResponse.userId;


    const data = {
        userId: userId,
        subject: subjectEl.value,
        isUrgent: isUrgentEl.value
    };

    await axios.post("https://localhost:7079/api/Tickets/Create", data);

    toastr.success('Ticket create is successful')

    gotoHome();
}

async function changeTicketStatus(id, event){
    var response = await Swal.fire({
        title: 'Change Status!',
        text: 'Do you want to change status this ticket',
        icon: 'question',
        confirmButtonText: 'Change',
        showCancelButton: true,
        cancelButtonText: "Cancel"
      });

      if(response.isConfirmed){
        const data = {
            id: id,
            status: event.target.value
        };
    
        await axios.post("https://localhost:7079/api/Tickets/ChangeStatus",data);
    
        toastr.info('Ticket status change is successful')    
      }

      gotoHome();
}

function checkValidation(e) {
    const isValid = e.target.validity.valid;

    if (!isValid) {
        e.target.className = "form-control is-invalid";
        const errorMessage = e.target.validationMessage;

        const divEl = document.querySelector("#" + e.target.id + " + div");
        divEl.innerHTML = errorMessage;
    } else {
        e.target.className = "form-control is-valid"
    }
}

function checkValidationForPassword(e) {
    e.target.className = "form-control is-invalid";
    checkValidationForPassword2(e.target.value);
}

function checkValidationForPassword2(value) {
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

    const specialCharacterLiEl = document.getElementById("specialCharacter");
    specialCharacterLiEl.className = isTrueReturnSuccessOrDanger(/[^\w\s]/.test(value));

    validation.min6Length = value.length >= 6;
    validation.upperCase = /[A-Z]/.test(value);
    validation.lowerCase = /[a-z]/.test(value);
    validation.number = /[0-9]/.test(value);
    validation.specialCharacter = /[^\w\s]/.test(value);

    for (let i in validation) {
        if (!validation[i]) return;
    }

    ulEl.style.display = "none";
    document.getElementById("password").className = "form-control is-valid";
}

function isTrueReturnSuccessOrDanger(expression) {
    if (expression) return "text-success"

    return "text-danger"
}

function login() {
    const userNameOrEmailEl = document.getElementById("userNameOrEmail");
    const userNameOrEmailIsValid = userNameOrEmail.validity.valid;

    const passwordEl = document.getElementById("password");
    const passwordIsValid = passwordEl.validity.valid;

    if (!userNameOrEmailIsValid) {
        userNameOrEmailEl.className = "form-control is-invalid";
        document.querySelector(`#userNameOrEmail + div`).innerHTML = userNameOrEmailEl.validationMessage;
    }

    if (!passwordIsValid) {
        passwordEl.className = "form-control is-invalid";
        checkValidationForPassword2(passwordEl.value);
    }

    const data = {
        userNameOrEmail: userNameOrEmailEl.value,
        password: passwordEl.value
    }

    if (userNameOrEmailIsValid && passwordIsValid) {
        axios.post("https://localhost:7079/api/Auth/Login", data)
            .then(res => {
                localStorage.setItem("response", JSON.stringify(res.data));
                gotoHome();
            })
            .catch(err => {
                console.log(err)
            })
    }
}

function register() {
    const nameEl = document.getElementById("name");
    const nameIsValid = nameEl.validity.valid;

    const lastNameEl = document.getElementById("lastName");
    const lastNameIsValid = lastNameEl.validity.valid;

    const userNameEl = document.getElementById("userName");
    const userNameIsValid = userNameEl.validity.valid;

    const emailEl = document.getElementById("email");
    const emailIsValid = emailEl.validity.valid;

    const passwordEl = document.getElementById("password");
    const passwordIsValid = passwordEl.validity.valid;

    if (!nameIsValid) {
        nameEl.className = "form-control is-invalid";
        document.querySelector(`#name + div`).innerHTML = nameEl.validationMessage;
    }

    if (!lastNameIsValid) {
        lastNameEl.className = "form-control is-invalid";
        document.querySelector(`#lastName + div`).innerHTML = lastNameEl.validationMessage;
    }

    if (!userNameIsValid) {
        userNameEl.className = "form-control is-invalid";
        document.querySelector(`#userName + div`).innerHTML = userNameEl.validationMessage;
    }

    if (!emailIsValid) {
        emailEl.className = "form-control is-invalid";
        document.querySelector(`#email + div`).innerHTML = emailEl.validationMessage;
    }


    if (!passwordIsValid) {
        passwordEl.className = "form-control is-invalid";
        checkValidationForPassword2(passwordEl.value);
    }

    if (nameIsValid && passwordIsValid && userNameIsValid && emailIsValid && lastNameIsValid) {
        const data = {
            name: nameEl.value,
            lastName: lastNameEl.value,
            username: userNameEl.value,
            email: emailEl.value,
            password: passwordEl.value
        }

        axios.post("https://localhost:7079/api/Auth/Register", data).then(res => {
            const Toast = Swal.mixin({
                toast: true,
                position: "bottom-end",
                showConfirmButton: false,
                timer: 3000,
                timerProgressBar: true,
                didOpen: (toast) => {
                    toast.onmouseenter = Swal.stopTimer;
                    toast.onmouseleave = Swal.resumeTimer;
                }
            });
            Toast.fire({
                icon: "success",
                title: "Kayıt işlemi başarıyla tamamlandı. Giriş yapabilirsiniz!"
            });
            gotoLogin();
        });
    }
}

function checkAuthentication() {
    if (localStorage.getItem("response")) return true;

    gotoLogin();
    return false;
}