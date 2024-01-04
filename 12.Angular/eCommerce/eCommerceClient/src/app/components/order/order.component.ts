import { Component, OnInit } from '@angular/core';
import { ProductModel } from '../../models/product.model';
import { CommonModule } from '@angular/common';
import { TrCurrencyPipe } from 'tr-currency';
import { OrderModel } from '../../models/order.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { api } from '../../constants/api';
import { AuthService } from '../../services/auth.service';
import { ErrorService } from '../../services/error.service';

@Component({
  selector: 'app-order',
  standalone: true,
  imports: [CommonModule, TrCurrencyPipe],
  templateUrl: './order.component.html',
  styleUrl: './order.component.css'
})
export class OrderComponent implements OnInit {
  orders:OrderModel[] = []

  constructor(
    private http: HttpClient,
    private auth: AuthService,
    private error: ErrorService
  ){}

  ngOnInit(): void {
    this.getAll();
  }

  getAll(){
    this.http.get<OrderModel[]>(`${api}/Orders/GetAll`, {
      headers: {
        "Authorization": "Bearer " + this.auth.token
      }
    })
    .subscribe({
      next: (res)=> {
        this.orders = res;
      },
      error: (err: HttpErrorResponse)=> this.error.errorHandler(err)
    })
  }
}
