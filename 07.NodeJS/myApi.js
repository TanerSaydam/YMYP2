const express = require("express");
const cors = require("cors");
const { log } = require("console");
const { todo } = require("node:test");
const app = express();

app.use(cors());
app.use(express.json());

//API metotlarımız => GET, POST, PUT, DELETE

const todos = ["Todo 1", "Todo 2", "Todo 3"];


app.get("/api", (req, res)=> {
    res.json({message: "API çalışıyor"});
});

app.get("/api/getAll", (req,res)=> {
    res.json(todos);
});

app.get("/api/removeByIndex/:id", (req,res)=> {
    const index = req.params.id;

    todos.splice(index, 1);

    res.json({});
})

app.post("/api/save", (req,res)=> {
    const {value} = req.body;
    console.log(req.body);
    todos.push(req.body.value);

    res.json({});
})

app.post("/api/update", (req,res)=> {
    const body = req.body;
    todos[body.index] = body.value;

    res.json({});
})

app.listen(7000,()=>{
    console.log("API localhost:7000 üzerinden ayakta...");
});

/*app.listen(7000,function() {
    console.log("API localhost:7000 üzerinden ayakta...");
});*/