console.log("Hello world");

//boolean, number, string, bigint, symbol, object, any,unknown

class User{
    degisken: number = 0;
    name = "Taner";
    age: any;    
    w: unknown;

    constructor(degisken: number, name: string){
        this.degisken = degisken;
        this.name = name;
    }

    metot(){        
        this.age = 10;
        this.age = "Taner";

        this.w = 20;
        this.w = "Hello";
        if(typeof this.w === "string"){
            console.log(this.w.toLowerCase());
        }
    }
}

const age: number = 10;

const names: string[] = ["Taner","Ahmet","Ayşe"];

const users: User[] = [];

const user: User = new User(0,"asdas");
users.push(user);

console.log(users);


type carYear = "Deneme1" | "Deneme2" | "Deneme3"

const d: carYear = "Deneme3"

enum enumType{
    deger1 = "Değer 1", //0
    deger2 = 10 //1
}

const type: enumType = enumType.deger1;


class Test{
    x: number = 0;
    y: number = 5;
    metot(callBack: (res:any)=> void){
        //işlemler
        this.x = this.y + 10;
        console.log("x = y + 10: " + this.x);
        
            
        callBack(this.x);

        //işlemler
        this.y = this.x * 5;
        console.log("y = x * 5: " + this.y);
    }
}

class Test2{
    constructor(private test: Test){

        this.test.metot((res)=> {
            res = res * 20;
            console.log("res = res * 20: " + res);
        })
    }
}

const test2: Test2 = new Test2(new Test())