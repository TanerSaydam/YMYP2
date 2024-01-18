import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(
    private router: Router
  ){}

  isAuthenticated(){
    const tokenString: string | null = localStorage.getItem("token")
    if(tokenString != null)
    {
      //token geçerlilik kontrolü
      return true;
    }

    this.router.navigateByUrl("/login");
    return false;
  }
}
