const rootEl = document.getElementById("root");

gotoHome();

function gotoHome()
{
    let inputValue = "";
    rootEl.innerHTML = `
    <h1>Home Page</h1>
    <input>
    <p>Bla bla bla</p>
    `
}

function gotoAbout()
{
    rootEl.innerHTML = `
    <h1>About Page</h1>
    <h2>Head</h2>
    <p>Content</p>
    <p>Content</p>
    <p>Content</p>
    `
}