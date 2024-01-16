import { Component } from '@angular/core';
import { StudentModel } from '../../models/student.model';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';
import { FormsModule } from '@angular/forms';

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
  datas: StudentModel[] = [
    {
      id: "1",
      firstname: "Taner",
      lastname: "Saydam",
      dateOfBirth: new Date("03.09.1989"),
      image: "student.jpg"
    },
    {
      id: "1",
      firstname: "Taner",
      lastname: "Saydam",
      dateOfBirth: new Date("03.09.1989"),
      image: "student.jpg"
    },
    {
      id: "1",
      firstname: "Taner",
      lastname: "Saydam",
      dateOfBirth: new Date("03.09.1989"),
      image: "student.jpg"
    }
  ];

  created: StudentModel = new StudentModel();
}
