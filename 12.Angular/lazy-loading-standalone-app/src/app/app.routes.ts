import { inject } from '@angular/core';
import { Routes } from '@angular/router';
import { AuthService } from './ui/services/auth.service';

export const routes: Routes = [
    {
        path: "login",
        loadComponent: ()=> import("./ui/components/login/login.component")
    },
    {
        path: "",
        canActivateChild: [()=> inject(AuthService).isAuthenticated()],
        loadComponent: ()=> import("./ui/components/layouts/layouts.component"),
        children: [
            {
                path: "",
                loadComponent: ()=> import("./ui/components/home/home.component"),
            },
            {
                path: "about",                
                loadComponent: ()=> import("./ui/components/about/about.component"),
            },
            // {
            //     path: "about/:p1/:p2/:p3",
            //     loadComponent: ()=> import("./ui/components/about/about.component"),
            // },
            {
                path: "contact",
                loadComponent: ()=> import("./ui/components/contact/contact.component"),
            }
        ]
    }
];
