import { Component } from '@angular/core';
import { BlankComponent } from '../../common/components/blank/blank.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [BlankComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

}
