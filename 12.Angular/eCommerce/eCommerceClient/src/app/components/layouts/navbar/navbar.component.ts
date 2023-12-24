import { Component } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { AuthService } from '../../../services/auth.service';
import { ShoppingCartService } from '../../../services/shopping-cart.service';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  constructor(
    public auth: AuthService,
    public cart: ShoppingCartService,
    private router: Router
  ) {
    this.auth.isAuthenticated();
  }

  logout(){
    localStorage.removeItem("response");
    this.auth.isAuthenticated();
    this.router.navigateByUrl("/");
  }
}
