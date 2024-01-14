import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path: "login",
        loadComponent:()=> import("./ui/components/login/login.component")
    },
    {
        path: "",
        loadComponent:()=> import("./ui/components/layouts/layouts.component"),
        children: [
            {
                path: "",
                loadComponent:()=> import("./ui/components/home/home.component")
            },
            {
                path: "contact",
                loadComponent:()=> import("./ui/components/contact/contact.component")
            }
        ]
    }
];
