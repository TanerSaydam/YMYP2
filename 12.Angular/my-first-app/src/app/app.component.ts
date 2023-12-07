import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, FormsModule],
  template: `
     <h1>Merhaba Dünya!</h1>
      <h2>Todo App</h2>
      <form (submit)="save()">
        <input [(ngModel)]="work" name="work">
        <button>Kaydet</button>
      </form>
      <ul>
      @for(t of todos; track t){
        <li> {{$index}}. {{t.title}}</li>
      }
      </ul>
  `
})
export class AppComponent {
  work: string = "";
  todos: any[] = [];

  constructor(private http: HttpClient){
    this.getTodos();
  }

  getTodos(){
    this.http
      .get("https://jsonplaceholder.typicode.com/todos")
      .subscribe((res:any)=> this.todos = res);    
  }

  save(){
    this.todos.push({title: this.work});
    this.work = "";
  }
}
