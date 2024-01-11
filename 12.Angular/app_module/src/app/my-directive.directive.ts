import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[myDirective]'
})
export class MyDirectiveDirective {

  @Input() myDirective:boolean = false;
  @Input() name: string = "";

  count: number = 0;
  constructor(
    private el: ElementRef<HTMLHeadElement>
  ) { }


  @HostListener("mouseenter") metot1(){
    this.count++;
    //console.log(this.el);
    //alert("Javascript kodu çalıştırıldı");
    //const element = document.querySelector("h1");
    
    console.log(this.myDirective);
    console.log(this.name);
    
    console.log("Mouse bu elementin üzerine geldi: " + this.count);    
  }
}
