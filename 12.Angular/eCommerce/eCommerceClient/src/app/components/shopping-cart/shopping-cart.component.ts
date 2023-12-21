import { Component } from '@angular/core';
import { TrCurrencyPipe } from 'tr-currency';

@Component({
  selector: 'app-shopping-cart',
  standalone: true,
  imports: [TrCurrencyPipe],
  templateUrl: './shopping-cart.component.html',
  styleUrl: './shopping-cart.component.css'
})
export class ShoppingCartComponent {
  numbers: number[] = [1,2,3,4,5,36,5,5,5,5,5,5,5]
}
