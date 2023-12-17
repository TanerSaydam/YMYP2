import { Component } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { TrCurrencyPipe } from 'tr-currency';
import { FormsModule } from '@angular/forms';
import { NgxMaskDirective, NgxMaskPipe, provideNgxMask } from 'ngx-mask';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, TrCurrencyPipe, FormsModule, NgxMaskDirective, NgxMaskPipe],
  providers: [DatePipe, provideNgxMask()],
  template:`
  <input type="text" mask="0000-0000-0000-0000" (keyup)="get($event)">
  <input type="text" mask="(000) 000 00 00" (keyup)="get($event)">
  <input type="text" [(ngModel)]="phoneNumber">
  <span>{{phoneNumber | mask: '+90(000) 000-0000'}}</span>
  <!-- <p>{{date}}</p>
  <p>{{date | date}}</p>
  <p>{{date | date: 'dd.MM.yyyy HH:mm:ss'}}</p>
  <input type="date" [(ngModel)]="dateString">
  <br>
  <input type="datetime-local" [(ngModel)]="dateTimeString">
  <br>
  <input type="time" [(ngModel)]="timeString"> -->
  <!-- <p>{{money | currency: '€'}}</p>
  <p>{{money | trCurrency: '€': true}}</p> -->  
  `
})
export class AppComponent {
  phoneNumber: string = ""
  money: number = 1255043.45; 
  date: Date = new Date();
  dateString: string | null = "";
  dateTimeString: string | null = "";
  timeString: string | null = ""
  //yyyy-MM-dd
  //xxxx xxxx xxxx xxxx

  get(event: any){
    console.log(event.target.value);
    
  }

  constructor(private datePipe: DatePipe){
    this.dateString = this.datePipe.transform(new Date(), 'yyyy-MM-dd')
    this.dateTimeString = this.datePipe.transform(new Date(), 'yyyy-MM-dd HH:mm')
    this.timeString = this.datePipe.transform(new Date(), 'HH:mm')
  }

}
