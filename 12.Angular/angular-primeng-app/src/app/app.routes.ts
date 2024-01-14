import { Routes } from '@angular/router';
import { LayoutsComponent } from './ui/components/layouts/layouts.component';
import { HomeComponent } from './ui/components/home/home.component';

export const routes: Routes = [
    {
        path: "",
        component: LayoutsComponent,
        children: [
            {
                path: "",
                component: HomeComponent
            }
        ]
    }
];
