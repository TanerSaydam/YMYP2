import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CountService {
  count: number = 0;

  increment(){
    this.count++;
  }

  decrement(){
    this.count--;
  }
}
