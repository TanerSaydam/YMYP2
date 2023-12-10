import { Component, ElementRef, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { ListComponent } from './list/list.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, FormsModule, ListComponent],
  template: `
        <h1>Todo App</h1>
        @if(!isUpdateFormActive){
          <div>
          <input #work [(ngModel)]="todo" placeholder="Write something...">
          <button (click)="save()">Save</button>
        </div>
        }
        @else {
          <div>
          <input [(ngModel)]="updateTodo" type="text">
          <button (click)="update()">Update</button>
          <button (click)="isUpdateFormActive = false">Cancel</button>
        </div>
        }

        <hr>
        <app-list [isUpdateFormActive]="isUpdateFormActive" [todoList]="todos" (updateEvent)="get($event)" (removeEvent)="remove($event)"></app-list>
        `
})
export class AppComponent {
  todos: {id: number, work: string}[] = []
  todo: string = "";
  updateTodo: string = "";
  updateId: number = 0;
  isUpdateFormActive: boolean = false;
  @ViewChild("work") workEl: ElementRef<HTMLInputElement> | undefined;
  
  constructor(
    private http: HttpClient
  ) {
    this.getAll()
  }

  getAll(){
    this.http.get("http://localhost:3000/todos")
   .subscribe((res:any) => {
    this.todos = res;
   })
  }

  get(index: number) {
    this.updateTodo = this.todos[index].work
    this.updateId = this.todos[index].id;
    this.isUpdateFormActive = true;
  }

  update() {
    const data = {
      id: this.updateId,
      work: this.updateTodo
    }
    this.http.put("http://localhost:3000/todos/" + data.id, data).subscribe(res=> {
      this.isUpdateFormActive = false;
      this.getAll();
    })
  }

  save() {
    if (this.todo === "") return;
    
    const data = {
      id: this.todos.length === 0 ? 1 : (this.todos[this.todos.length - 1].id + 1),
      work: this.todo
    }

    this.http.post("http://localhost:3000/todos", data).subscribe(res=> {
      this.getAll();
      this.todo = "";
      this.workEl?.nativeElement.focus();
    })
  }

  remove(id: number) {
    this.http.delete("http://localhost:3000/todos/" + id)
    .subscribe(res=> {
      this.getAll();
    })
  }
}
