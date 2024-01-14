import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutsComponent } from './layouts.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: "",
    component: LayoutsComponent,
    children: [
      {
        path: "",
        loadChildren: ()=> import("../home/home.module")
      },
      {
        path: "about",
        loadChildren: ()=> import("../about/about.module")
      },
      {
        path: "contact",
        loadChildren: ()=> import("../contact/contact.module")
      },
      {
        path: "**",
        loadChildren: ()=> import("../not-found/not-found.module")
      }
    ]
  }
]

@NgModule({
  declarations: [LayoutsComponent],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export default class LayoutsModule { }
