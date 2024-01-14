import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.css'
})
export default class ContactComponent {
  roles: string[] = [];

  constructor(){
    if(localStorage.getItem("roles")){
      const rolesString:any = localStorage.getItem("roles");
      this.roles = JSON.parse(rolesString);
    }
  }
}
