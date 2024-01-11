import { Directive } from '@angular/core';

@Directive({
  selector: '[appMyDirective]',
  standalone: true
})
export class MyDirectiveDirective {

  constructor() { }

}
