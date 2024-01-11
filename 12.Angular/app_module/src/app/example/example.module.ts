import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MyDirectiveDirective } from '../my-directive.directive';



@NgModule({
  declarations: [MyDirectiveDirective], //Component, pipe ve directive
  imports: [
    CommonModule
  ],
  exports: [MyDirectiveDirective]
})
export class ExampleModule { }
