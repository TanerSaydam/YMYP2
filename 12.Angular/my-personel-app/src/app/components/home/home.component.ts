import { Component, ElementRef, ViewChild } from '@angular/core';
import { PersonelModel, ProfessionType } from '../../models/personel.model';
import { FormControl, FormGroup, FormsModule, NgForm, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { PersonelPipe } from '../../pipes/personel.pipe';
import { NgxPaginationModule } from 'ngx-pagination';
import { ExampleDirective } from '../../directives/example.directive';
import { FormValidationDirective } from '../../directives/form-validation.directive';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FormsModule, CommonModule, PersonelPipe, NgxPaginationModule, ReactiveFormsModule, FormValidationDirective],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  @ViewChild("addPersonelModalCloseBtn") addCloseBtn: ElementRef<HTMLButtonElement> | undefined;
  @ViewChild("updatePersonelModalCloseBtn") updateCloseBtn: ElementRef<HTMLButtonElement> | undefined;

  addFormGroup: FormGroup = new FormGroup({
    firstName: new FormControl(""),
    lastName: new FormControl(""),
    profession: new FormControl("")
  });

  p: number = 1;

  personels: PersonelModel[] = [];
  createModel: PersonelModel = new PersonelModel();
  updateModel: PersonelModel = new PersonelModel();

  professions: ProfessionType[] = ["Accounting", "Software", "Teacher"];

  search: string = "";

  constructor(
    private http: HttpClient
  ) {
    this.getAll();
  }

  getAll() {
    this.http.get<PersonelModel[]>("http://localhost:3000/personels")
      .subscribe({
        next: (res) => {
          this.personels = res.sort((a, b) => b.firstName.localeCompare(a.firstName))
        },
        error: (err: HttpErrorResponse) => {
          console.log(err);
        }
      });
  }

  createFormGroup() {
    if (this.addFormGroup.valid) {
      this.http.post("http://localhost:3000/personels", this.createModel)
        .subscribe({
          next: (res: any) => {
            this.createModel = new PersonelModel();
            this.addCloseBtn?.nativeElement.click();

            this.getAll();
          },
          error: (err: HttpErrorResponse) => {
            console.log(err);
          }
        })
    }
  }

  create(form: NgForm) {
    if(!form.valid) return;
    
    this.http.post("http://localhost:3000/personels", this.createModel)
      .subscribe({
        next: (res: any) => {
          this.createModel = new PersonelModel();
          this.addCloseBtn?.nativeElement.click();

          this.getAll();
        },
        error: (err: HttpErrorResponse) => {
          console.log(err);
        }
      })
  }

  removeById(id: string) {
    this.http.delete("http://localhost:3000/personels/" + id)
      .subscribe({
        next: (res: any) => {
          this.getAll();
        },
        error: (err: HttpErrorResponse) => {
          console.log(err);
        }
      })
  }

  get(personel: PersonelModel) {
    this.updateModel = { ...personel };
  }

  update(form: NgForm) {
    if (form.valid) {
      this.http.put("http://localhost:3000/personels/" + this.updateModel.id, this.updateModel)
        .subscribe({
          next: (res: any) => {
            this.updateCloseBtn?.nativeElement.click();
            this.getAll();
          },
          error: (err: HttpErrorResponse) => {
            console.log(err);
          }
        })
    }
  }

  checkValidation(id: string) {
    const input: any = document.getElementById(id);    
    if (input === null) return;

    const divEl: any = document.querySelector(`#${id} + div`);
    if (divEl === null) return;

    divEl.innerHTML = input.validationMessage

    const valid: boolean = input.validity.valid;
    if (valid) {
      input.className = "form-control is-valid"
    } else {
      input.className = "form-control is-invalid"
    }
  }
}

