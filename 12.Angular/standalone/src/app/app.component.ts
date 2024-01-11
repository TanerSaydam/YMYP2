import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { MyDirectiveDirective } from './my-directive.directive';
import { SearchPipe } from './search.pipe';
import { HttpClient } from '@angular/common/http';
import { ProductService } from './product.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, MyDirectiveDirective, SearchPipe],
  providers: [ProductService],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'standalone';
  name: string = "";

  constructor(private http: HttpClient, private product: ProductService){}

  method(){
    this.http.get("").subscribe(
      res=> {}, 
      err => {})

      this.http.get("").subscribe({
        next: (res:any)=> {},
        error: (err:any)=> {}
      })
  }
}
