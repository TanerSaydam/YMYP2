import { Component } from '@angular/core';
import { TrCurrencyPipe } from 'tr-currency';
import { AuthService } from '../../services/auth.service';
import { ProductModel } from '../../models/product.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

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
  
  constructor(private auth: AuthService, private http: HttpClient){
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
}
