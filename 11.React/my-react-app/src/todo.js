
import axios from 'axios';
import { useEffect, useState } from 'react';

export function TodoComponent(){
    const [work, setWork] = useState("asdasd");
    const [todos, setTodos] = useState([]);
    
    const save = (e) => {
      e.preventDefault();
      setTodos((prev)=> [...prev, {title: work}]);
      setWork("");
    }
  
    function getTodos(){
      axios.get("https://jsonplaceholder.typicode.com/todos")    
      .then(res => {
        setTodos(res.data);
      })
    }
  
    useEffect(()=> {
      getTodos();
    },[])
  
    return(
    <>
        <h1>Merhaba Dünya!</h1>
        <h2>Todo App</h2>
        <form onSubmit={save}>
          <input value={work} onChange={(e)=> setWork(e.target.value)} className="" />
          <button>Kaydet</button>
        </form>
        <ul>
          {todos.map((val,i)=> <li key={i}>{i}. {val.title}</li>)}
        </ul>
      </>
    )
  }
  