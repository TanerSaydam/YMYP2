import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { LayoutsComponent } from './layouts/layouts.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { inject } from '@angular/core';
import { AuthService } from './auth.service';
import { authGuard } from './auth.guard';

export const routes: Routes = [
    {
        path: "login",
        component: LoginComponent
    },
    {
        path: "",
        component: LayoutsComponent,
        canActivateChild: [()=> inject(AuthService).isAuthenticated()],
        children: [
            {
                path: "",
                component: HomeComponent
            },
            {
                path: "about",
                component: AboutComponent,
                canDeactivate: [authGuard]
            }
        ]
    }
];
