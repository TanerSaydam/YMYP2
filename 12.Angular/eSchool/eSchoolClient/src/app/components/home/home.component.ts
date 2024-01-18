import { Component } from '@angular/core';
import { StudentModel } from '../../models/student.model';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { api } from '../../constants';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, RouterLink,
  FormsModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  search: string = ""
  datas: StudentModel[] = [];

  constructor(
    private http: HttpClient
  ){
    this.getAll();
  }

  getAll(){
    this.http.get<StudentModel[]>(`${api}/Students/GetAll`).subscribe(res=> {
      this.datas = res;
    })
  }
}
