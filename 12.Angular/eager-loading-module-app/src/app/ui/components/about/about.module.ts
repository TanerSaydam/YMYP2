import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import AboutComponent from './about.component';
import { Router, RouterModule } from '@angular/router';
import { SharedModule } from '../../../common/modules/shared.module';



@NgModule({
  declarations: [AboutComponent],
  imports: [
    SharedModule,
    RouterModule.forChild([
      {
        path: "",
        component: AboutComponent
      }
    ])
  ]
})
export default class AboutModule { }
