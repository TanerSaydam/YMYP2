import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MenuItem } from 'primeng/api';
import { MenubarModule } from 'primeng/menubar';

@Component({
  selector: 'app-layouts',
  standalone: true,
  imports: [RouterOutlet,MenubarModule],
  templateUrl: './layouts.component.html',
  styleUrl: './layouts.component.css'
})
export class LayoutsComponent {
  items: MenuItem[] | undefined;


  constructor(){
    this.items = [
      {
          label: 'Home',
          icon: 'pi pi-fw pi-home',
          items: []
      },
      {
          label: 'Orders',
          icon: 'pi pi-fw pi-file-o',
          items: []
      },      
      {
          label: 'Quit',
          icon: 'pi pi-fw pi-power-off'
      }
  ];
  }
}
