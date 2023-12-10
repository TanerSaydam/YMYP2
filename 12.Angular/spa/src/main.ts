const el:any = document.querySelector("app-root");

fetch("./taner.html").then(res=> res.text()).then(data=> {
    el.innerHTML = data;
})

function gotoAhmet(){
    const el:any = document.querySelector("app-root");
    fetch("./ahmet.html").then(res=> res.text()).then(data=> {
        el.innerHTML = data;
    })
}