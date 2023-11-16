const canvas = document.getElementById("game");
const ctx = canvas.getContext("2d");

document.addEventListener("keydown", tusHareketleri);

let x = 9;
let y = 9;
let elmaX = 5;
let elmaY = 5;
let boyut = 18;
let konum = 20;
let hareketX = 0;
let hareketY = 0;
let hiz = 10;
let yilanParcalari = [];
let yilanUzunlugu = 3;
let skor = 0;

class YilanParcasi{
    constructor(x,y){
        this.x = x;
        this.y = y;
    }
}

oyunuCiz();

function oyunuCiz(){
    ekraniTemizle();
    yilaniCiz();
    yilanHareketiniGuncelle();
    elmayiCiz();
    elmaninKonumunuDegistir();
    skoruCiz();
    setTimeout(oyunuCiz, 1000/hiz);
}

function ekraniTemizle(){
    ctx.fillStyle = "black";
    ctx.fillRect(0,0,400,400);
}

function yilaniCiz(){
    ctx.fillStyle = "green";
    for(let i = 0; i < yilanParcalari.length; i++){
        let part = yilanParcalari[i];
        ctx.fillRect(part.x * konum, part.y * konum,boyut, boyut);
    }

    yilanParcalari.push(new YilanParcasi(x,y))

    if(yilanParcalari.length > yilanUzunlugu){
        yilanParcalari.shift();
    }

    ctx.fillStyle = "white";
    ctx.fillRect(x * konum,y * konum,boyut,boyut);
}

function yilanHareketiniGuncelle(){
    let sonucX = x + hareketX;
    let sonucY = y + hareketY;

    if(sonucX > 19){
        x =0
    }else if(sonucX < 0){
        x = 19;
    }
    else{
        x = sonucX;
    }
    
    if(sonucY > 19){
        y = 0;
    }else if(sonucY < 0){
        y = 19
    }else{
        y = sonucY;
    }    
}

function elmayiCiz(){
    ctx.fillStyle = "red";
    ctx.fillRect(elmaX * konum, elmaY * konum, boyut, boyut);
}

function elmaninKonumunuDegistir(){
    if(x === elmaX && y === elmaY){
        elmaX = Math.floor(Math.random() * konum);
        elmaY = Math.floor(Math.random() * konum);

        let elmaKonumuMusaitMi = false;

        while(!elmaKonumuMusaitMi){
            elmaKonumuMusaitMi = true;
            yilanParcalari.forEach(kuyruk=> {
                if(kuyruk.x === elmaX && kuyruk.y === elmaY){
                    elmaX = Math.floor(Math.random() * konum);
                    elmaY = Math.floor(Math.random() * konum);
                    elmaKonumuMusaitMi = false;
                }
            })
        }


        yilanUzunlugu++;
        skor += 10;
    }
}

function skoruCiz(){
    ctx.fillStyle = "white";
    ctx.font = "20px verdena";
    ctx.fillText(`Skor: ${skor}`, 310,30)
}

function tusHareketleri(event){
    if(event.keyCode === 37) //sol tuşa basılı ise
    {
        hareketX = -1;
        hareketY = 0;
    }else if(event.keyCode === 39) //sağ tuşa basılı ise
    {
        hareketX = 1;
        hareketY = 0;
    }
    else if(event.keyCode === 38) //yukarı tuşa basılı ise
    {
        hareketY = -1;
        hareketX = 0;
    }
    else if(event.keyCode === 40) //yukarı tuşa basılı ise
    {
        hareketY = 1;
        hareketX = 0;
    }
}