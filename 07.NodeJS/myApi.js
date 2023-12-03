const express = require("express");
const cors = require("cors");
const mongoose = require("mongoose");

const app = express();

app.use(cors());
app.use(express.json());

//12:38 görüşelim

const uri = "mongodb://127.0.0.1:27017/tododb";
mongoose.connect(uri).then(res=> {
    console.log("Database bağlantısı başarılı")
}).catch(err=> {
    console.log(err);
});

const todoSchema = new mongoose.Schema({
    work: String,
    date: Date
});

const Todo = mongoose.model("Todo", todoSchema);

//API metotlarımız => GET, POST, PUT, DELETE

app.get("/api", (req, res)=> {
    res.json({message: "API çalışıyor"});
});

app.get("/api/getAll", async (req,res)=> {
    const todos = await Todo.find().sort({date: -1});
    res.json(todos);
});

app.post("/api/removeById", async (req,res)=> {
    const {_id} = req.body;

    await Todo.findByIdAndDelete(_id);

    res.json({});
})

app.post("/api/save", async (req,res)=> {
    const {value} = req.body;
   
    const todo = new Todo({work: value, date: new Date().setHours(new Date().getHours() + 15)});
    await todo.save();
    res.json({});
})

app.post("/api/update", async (req,res)=> {
    const {_id, value} = req.body;
    
    await Todo.findByIdAndUpdate(_id, {work: value});


    res.json({});
})

app.listen(7000,()=>{
    console.log("API localhost:7000 üzerinden ayakta...");
});

/*app.listen(7000,function() {
    console.log("API localhost:7000 üzerinden ayakta...");
});*/