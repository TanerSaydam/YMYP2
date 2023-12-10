"use strict";
const el = document.querySelector("app-root");
el.innerHTML = `
<taner>
    <div>
        <p>
            asdasdasd
        </p>
        <button onclick="gotoAhmet()">Ahmet Sayfasına Geç</button>
    </div>
</taner>

`
function gotoAhmet() {
    const el = document.querySelector("app-root");
    el.innerHTML = `    
    <ahmet>
    <h1>Hello</h1>
    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Fugit voluptas ut officiis quae fuga architecto doloremque eveniet assumenda velit eius! Repellat error exercitationem veritatis nostrum reiciendis eligendi aperiam, delectus dolor.</p>
</ahmet>
    `
}