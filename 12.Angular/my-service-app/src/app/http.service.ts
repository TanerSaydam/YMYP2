import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private http: HttpClient) { }


  get(api: string, callback: (res:any)=> void){
    this.http.get(api)
    .subscribe({
      next: (res:any)=> {
       callback(res);  
      },
      error: (err :HttpErrorResponse)=> {
        console.log(err);   
        if(err.status === 0){
          console.log("API adresi şu anda çalışmıyor!");
          
        }     
      }
    })
  }
}
