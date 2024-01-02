import { Component } from '@angular/core';
import { ProductModel } from '../../models/product.model';
import { CommonModule } from '@angular/common';
import { TrCurrencyPipe } from 'tr-currency';
import { OrderModel } from '../../models/order.model';

@Component({
  selector: 'app-order',
  standalone: true,
  imports: [CommonModule, TrCurrencyPipe],
  templateUrl: './order.component.html',
  styleUrl: './order.component.css'
})
export class OrderComponent {
  orders:OrderModel[] = []
}
