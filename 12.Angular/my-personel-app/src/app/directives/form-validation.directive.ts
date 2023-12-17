import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[formValidation]',
  standalone: true
})
export class FormValidationDirective {

  constructor(private el: ElementRef<HTMLFormElement>) { }

  @HostListener("submit") submit(){
    for(let i in this.el.nativeElement.elements){
      const el:any = this.el.nativeElement.elements[i]
      const id = el.id;
      this.checkValidation(id);     
    }    
  }

  // @HostListener("keyup") change(){
  //   this.submit();
  // }

  checkValidation(id: string) {
    const input: any = document.getElementById(id);
    if (input === null) return;

    const divEl: any = document.querySelector(`#${id} + div`);
    if (divEl === null) return;

    divEl.innerHTML = input.validationMessage

    const valid: boolean = input.validity.valid;
    if (valid) {
      input.className = "form-control is-valid"
    } else {
      input.className = "form-control is-invalid"
    }
  }

}
