"use strict";
function gotoAhmet() {
    const el = document.querySelector("app-root");
    fetch("./ahmet.html").then(res => res.text()).then(data => {
        el.innerHTML = data;
    });
}
