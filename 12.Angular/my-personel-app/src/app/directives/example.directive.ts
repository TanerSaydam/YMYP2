import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[example]',
  standalone: true
})
export class ExampleDirective {

  constructor(private el: ElementRef<HTMLButtonElement>) { }

  @HostListener("mouseenter") metot1(){
    console.log(this.el);    
  }

}
