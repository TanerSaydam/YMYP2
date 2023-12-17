import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { LayoutComponent } from './components/layout/layout.component';
import { HomeComponent } from './components/home/home.component';

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
