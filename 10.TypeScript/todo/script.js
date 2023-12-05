"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
class Todo {
    constructor() {
        this.id = 0;
        this.title = "";
        this.completed = false;
    }
}
let todos = [];
function getTodoList() {
    return __awaiter(this, void 0, void 0, function* () {
        todos = yield fetch("https://jsonplaceholder.typicode.com/todos").then(res => res.json());
        setData();
    });
}
function setData() {
    const el = document.querySelector("tbody");
    let text = "";
    for (let i in todos) {
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
        `;
    }
    if (el !== null) {
        el.innerHTML = text;
    }
}
function removeByIndex(index) {
    todos.splice(index, 1);
    setData();
}
