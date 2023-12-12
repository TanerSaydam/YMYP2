import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    standalone: true,
    imports: [FormsModule]
})
export class AppComponent {
  todos:string[] = [];
  work: string = "";
  updateWork: string = "";
  updateIndex: number = 0;
  isUpdateFormActive: boolean = false;

  save(){
    this.todos.push(this.work);
    this.work = "";
  }

  get(index: number){
    this.updateWork = this.todos[index];
    this.updateIndex = index;
    this.isUpdateFormActive = true;
  }

  update(){
    this.todos[this.updateIndex] = this.updateWork;
    this.cancel();
  }

  remove(index: number){
    const result = confirm("You want to delete this record?");
    if(result){
      this.todos.splice(index,1);
    }    
  }

  cancel(){
    this.isUpdateFormActive = false;
  }
}
