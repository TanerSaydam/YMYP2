import { Component, OnInit } from '@angular/core';
import { TrCurrencyPipe } from 'tr-currency';
import { ShoppingCartModel } from '../../models/shopping-cart.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { ShoppingCartService } from '../../services/shopping-cart.service';
import { AuthService } from '../../services/auth.service';
import { api } from '../../constants/api';

@Component({
  selector: 'app-shopping-cart',
  standalone: true,
  imports: [TrCurrencyPipe],
  templateUrl: './shopping-cart.component.html',
  styleUrl: './shopping-cart.component.css'
})
export class ShoppingCartComponent implements OnInit {
  constructor(
     private http: HttpClient,
     private auth: AuthService,
     public _cart: ShoppingCartService) { } //yapıcı metot => class çağrıldığı esnada ilk çalışan metot

  ngOnInit(): void { }  

  decrement(cart: ShoppingCartModel){
    if(cart.quantity === 1){
      const response = confirm("Ürünü sepetten kaldırmak istiyor musunuz?")
      if (response) {
        this._cart.decrement(cart.productId);
      }
    }else{
      this._cart.decrement(cart.productId);
    }
  } 

  remove(id: number) {
    const response = confirm("Ürünü sepetten kaldırmak istiyor musunuz?")
    if (response) {
      this.http.get(`${api}/ShoppingCarts/RemoveById?id=${id}`, {
        headers: {
          "Authorization": "Bearer " + this.auth.token
        }
      })
      .subscribe({
        next: ()=> {
          this._cart.getAll();
        },
        error: (err: HttpErrorResponse)=> {
          console.log(err);          
        }
      })
    }
  }  

  pay(){
    const response = confirm("Ödeme yapmak istiyor musunuz?");
    if(response){
      this.http.get(`${api}/ShoppingCarts/Pay`,{
        headers: {
          "Authorization": "Bearer " + this.auth.token
        }
      })
      .subscribe({
        next: ()=> {
          this._cart.getAll();
        },
        error: (err: HttpErrorResponse)=> {
          console.log(err);        
        }
      })
    }    
  }
}
