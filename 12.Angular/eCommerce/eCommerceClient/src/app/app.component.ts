import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ToastModule } from 'primeng/toast';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ToastModule],
  template: `
  <p-toast position="bottom-right" [life]="3000"></p-toast>  
  <router-outlet></router-outlet>
  `
})
export class AppComponent {}
