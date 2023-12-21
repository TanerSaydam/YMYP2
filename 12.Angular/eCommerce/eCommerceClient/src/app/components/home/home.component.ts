import { Component } from '@angular/core';
import { TrCurrencyPipe } from 'tr-currency';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [TrCurrencyPipe],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  numbers: number[] = [];

  constructor(){
    for (let i = 0; i < 100; i++) {
      this.numbers.push(i);      
    }
  }
}
