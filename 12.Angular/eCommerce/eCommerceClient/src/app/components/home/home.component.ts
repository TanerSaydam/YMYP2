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
    this.http.get("https://localhost:7194/api/Products/GetAll",{
      headers: {
        "Authorization": "Bearer " + this.auth.token
      }
    }).subscribe({
      next: (res:any)=> {
        this.products = res;
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

  showDownButton(event: any){
    console.log(event);  
    const id = event.target.id;
    
    event.target.classList.add("d-none");
    const el:any = document.querySelector("#" + id + "+ div");
    el.className = "d-flex mt-2"
  }  

  showOriginalButton(event:any){    
    const divId:string = event.target.id;
    const buttonId = divId.replace("div-","btn-");

    const buttonEl = document.getElementById(buttonId);
    buttonEl?.classList.remove("d-none");

    const el:any = document.querySelector("#" + buttonId + "+ div");
    el.className = "d-none mt-2"
  }
}
