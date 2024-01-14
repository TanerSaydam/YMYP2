import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private router: Router) { }

  isAuthenticated(){
    if(localStorage.getItem("token")){
      return true;
    }

    this.router.navigateByUrl("/login");
    return false;
  }
}
