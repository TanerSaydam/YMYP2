import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { FormsModule, NgForm } from '@angular/forms';
import { PersonelModel, ProfessionType } from './models/personel.model';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  professionTypes: ProfessionType[] = ["Software","Accounting","Cleaner"];
  personels: PersonelModel[] = [];
  createModel: PersonelModel = new PersonelModel();
  constructor(){
    this.getAll();
  }

  getAll(){
    fetch("http://localhost:3000/personels")
    .then(res=> res.json())
    .then(data=> this.personels = data);
  }


  add(form: NgForm){    
    if(form.valid){
        fetch("http://localhost:3000/personels",{
        method: "POST",
        headers: {
          "Content-Type": "application/json"
        },
        body: JSON.stringify(this.createModel)
        })
        .then(res=> res.json())
        .then(data=> {
          this.createModel = new PersonelModel();
          this.getAll();
          const el = document.getElementById("addPersonelCloseBtnModal");
          el?.click();      
        })
    }
  }
}
