import { NgModule } from '@angular/core';
import { NotFoundComponent } from './not-found.component';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../../../common/modules/shared.module';

@NgModule({
  declarations: [NotFoundComponent],
  imports: [
    SharedModule,
    RouterModule.forChild([
      {
        path: "",
        component: NotFoundComponent
      }
    ])
  ]
})
export default class NotFoundModule { }
