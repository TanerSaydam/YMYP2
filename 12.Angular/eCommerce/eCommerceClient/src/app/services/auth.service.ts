import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  hasAuthenticated: boolean = false;

  constructor() { }

  isAuthenticated(){
    const responseString = localStorage.getItem("response");
    if(responseString){
      this.hasAuthenticated = true;
      return true;
    }
    
    this.hasAuthenticated = false;
    return false;

  }
}
