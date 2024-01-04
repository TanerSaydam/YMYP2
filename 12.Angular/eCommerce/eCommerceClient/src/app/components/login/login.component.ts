import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { AfterViewInit, Component, ElementRef, ViewChild } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { api } from '../../constants/api';
import { MessageService } from 'primeng/api';
import { ErrorService } from '../../services/error.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [RouterLink, FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements AfterViewInit {
  @ViewChild("email") emailInput: ElementRef<HTMLInputElement> | undefined;

  constructor(
    private http: HttpClient, 
    private router: Router,
    private error:ErrorService){}

  ngAfterViewInit(): void {
    this.emailInput?.nativeElement.focus();
  }

  signIn(form:NgForm) {
    if(form.valid){
      this.http.post(`${api}/Auth/Login`, form.value)
      .subscribe({
        next: (res: any)=> {
          localStorage.setItem("response", JSON.stringify(res));
          this.router.navigateByUrl("/");
        },
        error: (err: HttpErrorResponse)=> this.error.errorHandler(err)
      })
    }
  }
}
