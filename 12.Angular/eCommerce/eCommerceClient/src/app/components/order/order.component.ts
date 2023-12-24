import { Component } from '@angular/core';
import { ProductModel } from '../../models/product.model';
import { CommonModule } from '@angular/common';
import { TrCurrencyPipe } from 'tr-currency';

@Component({
  selector: 'app-order',
  standalone: true,
  imports: [CommonModule, TrCurrencyPipe],
  templateUrl: './order.component.html',
  styleUrl: './order.component.css'
})
export class OrderComponent {
  orders:any[] = [
    {
      "id": 1,
      "number": "S00000000001",
      "date": "24.12.2023 11:27",
      "expectedArrival": "26.12.2023",
      "cargoCompany": "UPS",
      "cargoTrackingNumber": "234094567242423422898",
      "details": [
        {
          "id":1,
          "productId":1,
          "price":100,
          "quantity": 1,
          "product": {
            "id": 1,
            "name": "Elma",
            "coverImageUrl": "elma.png",
            "price": 100
          }
        },
        {
          "id":2,
          "productId":1,
          "price":100,
          "quantity": 1,
          "product": {
            "id": 1,
            "name": "Elma",
            "coverImageUrl": "elma.png",
            "price": 100
          }
        }
      ]
    },
    {
      "id": 2,
      "number": "S00000000002",
      "date": "24.12.2023 11:27",
      "expectedArrival": "26.12.2023",
      "cargoCompany": "UPS",
      "cargoTrackingNumber": "234094567242423422898",
      "details": [
        {
          "id":1,
          "productId":1,
          "price":100,
          "quantity": 1,
          "product": {
            "id": 1,
            "name": "Elma",
            "coverImageUrl": "elma.png",
            "price": 100
          }
        }
      ]
    }
  ]
}
