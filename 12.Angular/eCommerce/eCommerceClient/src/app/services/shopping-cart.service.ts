import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ShoppingCartService {

  count: number = 0;

  constructor(private http: HttpClient) {
    this.getCount();
  }

  getCount() {
    this.http.get("")
      .subscribe({
        next: ((res: any) => {
          this.count = res.count;
        }),
        error: (err: HttpErrorResponse) => {
          console.log(err);
        }
      })
  }
}
