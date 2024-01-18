import { HttpClient } from '@angular/common/http';
import { AfterViewInit, Component, ElementRef, ViewChild } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { api } from '../../constants';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements AfterViewInit {
  @ViewChild("input") inputEl: ElementRef<HTMLInputElement> | undefined;

  emailOrUserName: string = "";

  constructor(
    private router: Router,
    private http: HttpClient
  ){}

  ngAfterViewInit(): void {
    this.inputEl?.nativeElement.focus();
  }

  signIn(){
    this.http.get(`${api}/Auth/SignIn?emailOrUserName=${this.emailOrUserName}`) //query parameter
    .subscribe((res:any)=> {
      localStorage.setItem("token", res.token);
      this.router.navigateByUrl("/");   
    });     
  }
}
