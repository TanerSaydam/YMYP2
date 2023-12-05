"use strict";
console.log("Hello world");
//boolean, number, string, bigint, symbol, object, any,unknown
class User {
    constructor(degisken, name) {
        this.degisken = 0;
        this.name = "Taner";
        this.degisken = degisken;
        this.name = name;
    }
    metot() {
        this.age = 10;
        this.age = "Taner";
        this.w = 20;
        this.w = "Hello";
        if (typeof this.w === "string") {
            console.log(this.w.toLowerCase());
        }
    }
}
const age = 10;
const names = ["Taner", "Ahmet", "Ayşe"];
const users = [];
const user = new User(0, "asdas");
users.push(user);
console.log(users);
const d = "Deneme3";
var enumType;
(function (enumType) {
    enumType["deger1"] = "De\u011Fer 1";
    enumType[enumType["deger2"] = 10] = "deger2"; //1
})(enumType || (enumType = {}));
const type = enumType.deger1;
class Test {
    constructor() {
        this.x = 0;
        this.y = 5;
    }
    metot(callBack) {
        //işlemler
        this.x = this.y + 10;
        console.log("x = y + 10: " + this.x);
        callBack(this.x);
        //işlemler
        this.y = this.x * 5;
        console.log("y = x * 5: " + this.y);
    }
}
class Test2 {
    constructor(test) {
        this.test = test;
        this.test.metot((res) => {
            res = res * 20;
            console.log("res = res * 20: " + res);
        });
    }
}
const test2 = new Test2(new Test());
