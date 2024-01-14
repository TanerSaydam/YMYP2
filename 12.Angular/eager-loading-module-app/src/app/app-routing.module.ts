import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: "login",
    loadChildren:()=> import("./ui/components/login/login.module")
  },
  {
    path: "",
    loadChildren: ()=> import("./ui/components/layouts/layouts.module"),    
  }
];

//Tüm verilerin bir defa yüklenip sayfa refresh yiyene kadar bir daha yüklenmemesine eager loading


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
