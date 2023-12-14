import { Component } from '@angular/core';
import { PersonelModel, ProfessionType } from '../models/personel.model';
import { FormsModule, NgForm } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { PersonelPipe } from '../pipes/personel.pipe';
import { NgxPaginationModule } from 'ngx-pagination';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FormsModule,CommonModule, PersonelPipe, NgxPaginationModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  createModel: PersonelModel = new PersonelModel();
  p:number = 1;
  personels: PersonelModel[] = [];

  professions: ProfessionType[] = ["Accounting","Software","Teacher"];
  search: string = "";
  
  constructor(
    private http: HttpClient
  ){
    this.getAll();
  }
  getAll(){
    this.http.get<PersonelModel[]>("http://localhost:3000/personels")
      .subscribe({
        next: (res)=> {
          this.personels = res          
        },
        error: (err: HttpErrorResponse)=> {
          console.log(err);
        }
      });
  }

  create(form: NgForm){
    if(form.valid){
      this.http.post("http://localhost:3000/personels",this.createModel)
        .subscribe({
          next: (res:any)=> {
            this.createModel = new PersonelModel();
            const el: HTMLButtonElement = document.getElementById("addPersonelModalCloseBtn") as HTMLButtonElement;
            el.click();
            this.getAll();
          },
          error: (err: HttpErrorResponse)=> {
            console.log(err);
          }
        })
    }
  }

  removeById(id: string){
    this.http.delete("http://localhost:3000/personels/" + id)
    .subscribe({
      next: (res:any)=> {        
        this.getAll();
      },
      error: (err: HttpErrorResponse)=> {
        console.log(err);
      }
    })
  }
}

