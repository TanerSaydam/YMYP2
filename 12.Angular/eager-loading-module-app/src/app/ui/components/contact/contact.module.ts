import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContactComponent } from './contact.component';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../../../common/modules/shared.module';



@NgModule({
  declarations: [ContactComponent],
  imports: [
    SharedModule,
    RouterModule.forChild([
      {
        path: "",
        component: ContactComponent
      }
    ])
  ]
})
export default class ContactModule { }
