import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { CountComponent } from './count/count.component';
import { OperationsComponent } from './operations/operations.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, CountComponent, OperationsComponent],
  template:`
  <app-count [count2]="count1"></app-count>
  <app-operations (myIncrementEvent)="increment()" (myDecrementEvent)="decrement()"></app-operations>
  `
})
export class AppComponent {
  count1: number = 0;

  increment(){
    this.count1++;
  }

  decrement(){
    this.count1--;
  }
}
