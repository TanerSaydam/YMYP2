import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  template:`
  <!-- <h1>Standalone App Component</h1> -->
  <h1>22:17 görüşelim</h1>
  <button (click)="getAll()">Call API</button>
  
  `
})
export class AppComponent {
  constructor(
    private http: HttpClient
  ){}

  getAll(){
    this.http.get("https://localhost:7028/api/Values/GetAll")
    .subscribe(res=> console.log(res));    
  }
}
