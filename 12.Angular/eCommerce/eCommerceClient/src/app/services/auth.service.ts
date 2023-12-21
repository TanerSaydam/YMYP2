import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor() { }

  isAuthenticated(){
    const responseString = localStorage.getItem("response");
    if(responseString){
      return true;
    }

    return false;

  }
}
