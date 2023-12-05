class Todo{
    id: number = 0;
    title: string = "";
    completed: boolean = false;
}

let todos: Todo[] = [];

async function getTodoList(){
    todos = await fetch("https://jsonplaceholder.typicode.com/todos").then(res=> res.json());
    setData();
    
}

function setData(){
    const el = document.querySelector("tbody");
    let text = "";
    for(let i in todos){
        text += `
        <tr>
            <td>${i + 1}</td>
            <td>${todos[i].title}</td>
            <td>${todos[i].completed}</td>
            <td>
                <button>Update</button>
                <button onclick="removeByIndex(${i})">Remove</button>
            </td>
        </tr>
        `
    }

    if(el !== null){
        el.innerHTML = text;
    }
}

function removeByIndex(index:number){   
    todos.splice(index,1);
    setData();
}