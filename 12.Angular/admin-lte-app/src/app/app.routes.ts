import { Routes } from '@angular/router';
import { LayoutsComponent } from './ui/layouts/layouts.component';
import { HomeComponent } from './ui/home/home.component';
import { ContactComponent } from './ui/contact/contact.component';

export const routes: Routes = [
    {
        path: "",
        component: LayoutsComponent,
        children: [
            {
                path: "",
                component: HomeComponent
            },
            {
                path: "contact",
                component: ContactComponent
            }
        ]
    }
];
