import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { ExampleNoProvideService, ExampleProvideService } from './example.service';
import { TestComponent } from './test/test.component';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { HttpService } from './http.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, TestComponent],
  providers: [ExampleNoProvideService],
  template:`
  <h1>Hello World</h1>
  <button (click)="change()">Change Service Degisken</button>
  <app-test></app-test>
  `
})
export class AppComponent {
  constructor(
    private service1: ExampleProvideService,
    private service2: ExampleNoProvideService,
    private http: HttpService
  ){
    this.http.get("https://localhost:30000/404",(res)=> {
      console.log(res);

    })
  }

  change(){
    this.service1.degisken = "Taner Saydam"
  }
}