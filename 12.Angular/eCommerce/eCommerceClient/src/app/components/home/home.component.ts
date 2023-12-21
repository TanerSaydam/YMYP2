import { Component } from '@angular/core';
import { TrCurrencyPipe } from 'tr-currency';
import { AuthService } from '../../services/auth.service';
import { ProductModel } from '../../models/product.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { ShoppingCartService } from '../../services/shopping-cart.service';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [TrCurrencyPipe],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  products: ProductModel[] = [];
  isAuthenticated: boolean = false;
  
  constructor(
    private auth: AuthService, 
    private http: HttpClient,
    private cart: ShoppingCartService){
    this.isAuthenticated = this.auth.isAuthenticated();

    this.getAllProduct();
  }

  getAllProduct(){
    this.http.get("assets/db.json").subscribe({
      next: (res:any)=> {
        this.products = res.products;
      },
      error: (err: HttpErrorResponse)=> {
        console.log(err);        
      }
    })
  }

  addShoppingCart(productId: number){
    this.http.get("https://jsonplaceholder.typicode.com/todos") //burayı değiştireceğiz
    .subscribe({
      next: (res:any)=> {
        this.cart.count++;
      },
      error: (err: HttpErrorResponse)=> {
        console.log(err);        
      }
    })
    
  }
}
