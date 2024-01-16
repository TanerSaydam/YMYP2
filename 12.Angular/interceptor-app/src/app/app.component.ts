import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template:`
  <h1>App Component</h1>
  <button (click)="getAll()">Call API</button>
  `
})
export class AppComponent {
  constructor(
    private http: HttpClient
  ){}

  getAll(){
    this.http.get("https://localhost:7028/api/Values/GetAll")
    .subscribe({
      next: (res)=> {
        console.log(res);        
      },
      error: (err: HttpErrorResponse)=> {
        console.log(err);        
      }
    })
  }
}
