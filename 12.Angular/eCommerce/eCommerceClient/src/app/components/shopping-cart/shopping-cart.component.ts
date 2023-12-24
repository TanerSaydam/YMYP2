import { Component, OnInit } from '@angular/core';
import { TrCurrencyPipe } from 'tr-currency';
import { ShoppingCartModel } from '../../models/shopping-cart.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-shopping-cart',
  standalone: true,
  imports: [TrCurrencyPipe],
  templateUrl: './shopping-cart.component.html',
  styleUrl: './shopping-cart.component.css'
})
export class ShoppingCartComponent implements OnInit {
  carts: ShoppingCartModel[] = [];
  sum: number = 0;

  constructor(private http: HttpClient) { } //yapıcı metot => class çağrıldığı esnada ilk çalışan metot

  ngOnInit(): void {
    this.getAll();
  }

  getAll() {
    this.http.get("assets/db.json")
      .subscribe({
        next: (res: any) => {
          this.carts = res.carts;

          this.calculateSum();
        },
        error: (err: HttpErrorResponse) => {
          console.log(err);
        }
      })
  }

  increment(cart: ShoppingCartModel) {
    cart.quantity++;

    this.calculateSum();
  }

  decrement(cart: ShoppingCartModel) {
    if (cart.quantity === 1) {
      const response = confirm("Ürünü sepetten kaldırmak istiyor musunuz?")
      if (response) {
        const index = this.carts.findIndex(p => p === cart);
        this.carts.splice(index, 1);

        this.calculateSum();
      }
      return;
    }
    cart.quantity--;

    this.calculateSum();
  }

  remove(index: number) {
    const response = confirm("Ürünü sepetten kaldırmak istiyor musunuz?")
    if (response) {
      this.carts.splice(index, 1);
    }
  }

  calculateSum(){
    this.sum = 0;
    for(const cart of this.carts){
        this.sum += cart.quantity * cart.product.price;
    }
  }
}
