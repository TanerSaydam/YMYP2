import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { LayoutComponent } from './layout/layout.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
    {
        path: "login",
        component: LoginComponent
    },
    {
        path : "",
        component: LayoutComponent,
        children: [
            {
                path: "",
                component: HomeComponent
            }
        ]
    }
];
