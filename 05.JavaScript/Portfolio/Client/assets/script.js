let skills = [
    "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/2048px-.NET_Core_Logo.svg.png",
    "https://blog.ninja-squad.com/assets/images/angular_gradient.png",
    "https://pluralsight2.imgix.net/paths/images/domain-driven-design-6d10f953a0.png",
    "https://upload.wikimedia.org/wikipedia/commons/e/ea/Docker_%28container_engine%29_logo_%28cropped%29.png"
]

let projects = [
    {
        id: "1",
        coverImageUrl: "project1.png",
        name: "e-Muhasebe Projesi"
    },
    {
        id: "2",
        coverImageUrl: "project2.png",
        name: "e-Finans Projesi"
    },
    {
        id: "3",
        coverImageUrl: "project3.png",
        name: "My Portfolio Projesi"
    }
]

let experiences= [
    {
        year: "2 Years",
        title: "Visual Art &amp; Design",
        date: "09.2011 - 08.2013",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.",
    },
    {
        year: "2 Years",
        title: "Visual Art &amp; Design",
        date: "09.2011 - 08.2013",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.",
    },
    {
        year: "2 Years",
        title: "Visual Art &amp; Design",
        date: "09.2011 - 08.2013",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.",
    },
    {
        year: "2 Years",
        title: "Visual Art &amp; Design",
        date: "09.2011 - 08.2013",
        description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed efficitur ex sit amet massa scelerisque scelerisque. Aliquam erat volutpat. Aenean interdum finibus efficitur. Praesent dapibus dolor felis, eu ultrices elit molestie.",
    }
]

getSkills();
getProjects();
getExperiences();

function getSkills(){
    let text = "";
    const el = document.querySelector(".skills");

    for(let s of skills){
        text += 
        `<li>
            <img src="${s}"/>
        </li>`
    }

    setTimeout(() => {
        el.innerHTML = text;    
    }, 3000);
    
}

function getProjects(){
    let text = "";
    const el = document.getElementById("projectRow");

    for(let p of projects){
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

    setTimeout(() => {
        el.innerHTML = text;    
    }, 3000);
    
}

function getExperiences(){
    let text = "";
    const el = document.getElementById("timeline");

    for(let e of experiences){
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

    setTimeout(() => {
        el.innerHTML = text;        
    }, 3000);
}