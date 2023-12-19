import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { jwtDecode } from 'jwt-decode';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(
    private router: Router
  ) { }

  isAuthenticated() {   
    const accessTokenString =  localStorage.getItem("accessToken");

    if (accessTokenString !== null) {
      try {
        const decode = jwtDecode(accessTokenString); 
        return true; 
      } catch (error) {
        this.router.navigateByUrl("/login");
        return false;
      }      
    }

    this.router.navigateByUrl("/login");
    return false;
  }
}
