import { Component, ElementRef, ViewChild } from '@angular/core';
import { StudentModel } from '../../models/student.model';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { api } from '../../constants';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './add.component.html',
  styleUrl: './add.component.css'
})
export class AddComponent {
  @ViewChild("image") imageEl: ElementRef<HTMLInputElement> | undefined;

  create:StudentModel = new StudentModel();

  constructor(
    private http: HttpClient,
    private router: Router
  ){}

  add(){
    const formData = new FormData();
    formData.append("firstName", this.create.firstname);
    formData.append("lastname", this.create.lastname);
    formData.append("dateOfBirth", this.create.dateOfBirth);
    if(this.create.file){
      formData.append("file", this.create.file, this.create.file.name);
    }
    
    this.http.post(`${api}/Students/Add`,formData).subscribe(()=> {
        this.router.navigateByUrl("/");
    })
  }

  selectImage(event:any){    
    //seçtiğimiz dosyayı değişkene set etme işlemi
    this.create.file = event?.target?.files[0]; 

    //set edilen dosyayı bir değişkene atayıp img elemetinde gösterme işlemi
    if (this.create.file) {
      const reader = new FileReader();
      
      reader.onload = (e: any) => {
        this.create.image = e.target.result;
      };
  
      reader.readAsDataURL(this.create.file);
    }
  }

  clearSelectedImage(){
    //seçilen dosyayı iptal edip default veriye dönme işlemi
    this.create.image = "assets/files/no-image.png";
    this.create.file = null; 
    if(this.imageEl != undefined){      
      this.imageEl.nativeElement.value = "";
    }    
  }
}
