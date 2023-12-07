import { Component } from '@angular/core';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [],
  template:`
  <h1>About Page</h1>
  <button (click)="changeColor()">Rengi Değiştir</button>
  <br>
  @if(isColorRed){
    <button style="background-color: red; color:white">Kırmızı</button>
  }@else {
    <button style="background-color: blue; color:white">Mavi</button>
  } 
  `
})
export class AboutComponent {
  isColorRed: boolean = false;

  changeColor(){
    this.isColorRed = !this.isColorRed;
  }
}
