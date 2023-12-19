import { Component } from '@angular/core';
import { PreloaderComponent } from '../preloader/preloader.component';
import { NavbarComponent } from '../navbar/navbar.component';
import { MainSidebarComponent } from '../main-sidebar/main-sidebar.component';
import { FooterComponent } from '../footer/footer.component';
import { ControlSidebarComponent } from '../control-sidebar/control-sidebar.component';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-layouts',
  standalone: true,
  imports: [PreloaderComponent, NavbarComponent, MainSidebarComponent, FooterComponent, ControlSidebarComponent, RouterOutlet],
  templateUrl: './layouts.component.html',
  styleUrl: './layouts.component.css'
})
export class LayoutsComponent {

}
