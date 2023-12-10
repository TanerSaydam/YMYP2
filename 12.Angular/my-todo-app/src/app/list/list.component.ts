import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-list',
  standalone: true,
  imports: [],
  template: `
  <ul> 
    @for(todo of todoList; track todo){
    <li>
      <span>{{todo.work}}</span>
      @if(!isUpdateFormActive){
        <button (click)="get($index)">Update</button>
        <button (click)="remove(todo.id)">Sil</button>
      }            
    </li>
    }@empty {
      <p>Listede gösterilecek değer yok</p>
    }
  </ul>`
})
export class ListComponent {
 @Input() todoList: {id: number, work: string}[] = []; //state management
 @Output() removeEvent = new EventEmitter<number>();
 @Output() updateEvent = new EventEmitter<number>();
 @Input() isUpdateFormActive: boolean = false;

  get(index: number){
    this.updateEvent.emit(index);
  }

  remove(id: number){
    this.removeEvent.emit(id);
  }
}
