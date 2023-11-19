getSkills();
getProjects();
getExperiences();
getSocialMedias();

function getSkills(){
    fetch("https://testportfoliowebapi.ecnorow.com/api/Home/GetSkills")
    .then(res=> res.json())
    .then(data=> {
        let text = "";
        const el = document.querySelector(".skills");
    
        for(let s of data){
            text += 
            `<li>
                <img src="${s.imageUrl}"/>
            </li>`
        }
    
        el.innerHTML = text; 
    });    
}

async function getProjects(){
    var res = await fetch("https://testportfoliowebapi.ecnorow.com/api/Home/GetProjects").then(res=> res.json());
    
    // console.log(data);
    let text = "";
    const el = document.getElementById("projectRow");

    for(let p of res){
        text += `
            <div class="col-lg-4 col-md-6 col-sm-6 col-12 mt-2">                
                <div class="card">
                    <div class="card-body  card-img">
                        <img src="./assets/projects/${p.coverImageUrl}" class="project-img">
                    </div>
                    <div class="card-header text-center">
                        <h1 class="text-center">${p.name}</h1>
                        <div class="float-right">
                            <span>Detaya Git</span>
                            <i class="fa-brands fa-google-play"></i>
                        </div>
                    </div>
                </div>
            </div>
        `
    }

    el.innerHTML = text;
}

async function getExperiences(){
    var res = await fetch("https://testportfoliowebapi.ecnorow.com/api/Home/GetExperiences").then(res=> res.json());
    
    let text = "";
    const el = document.getElementById("timeline");

    for(let e of res){
        text += `
            <div class="timeline">
                    <div class="icon"></div>
                    <div class="date-content">
                        <div class="date-outer">
                            <span class="date">
                                <span class="year">${e.year}</span>
                            </span>
                        </div>
                    </div>
                    <div class="timeline-content">
                        <h5 class="title">${e.title}</h5>
                        <h6>${e.date}</h6>
                        <p class="description">
                            ${e.description}
                        </p>
                    </div>
                </div>
        `
    }
    el.innerHTML = text;
}


async function getSocialMedias(){
    var res = await axios.get("https://testportfoliowebapi.ecnorow.com/api/Home/GetSocialMedias")

    let text = "";
    let textNavbar = "";
    const el = document.getElementById("socialMedia");
    const navbarEl = document.getElementById("navbarSocialMedia");

    for(let d of res.data){
        text += `
        <li class="ms-3">
            <a class="text-body-secondary" title="${d.name}" target="_blank" href="${d.link}">
               <i class="${d.icon}"></i>
            </a>
        </li>
        `

        textNavbar += `
        <li>
           <a class="dropdown-item"
              target="_blank"
              href="${d.link}">
             ${d.name}
           </a>
        </li>
        `
    }
    el.innerHTML = text;
    navbarEl.innerHTML = textNavbar;
}