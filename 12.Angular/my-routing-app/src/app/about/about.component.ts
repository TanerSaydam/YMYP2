import { Component } from '@angular/core';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [],
  templateUrl: './about.component.html',
  styleUrl: './about.component.css'
})
export class AboutComponent {

  constructor(){
    console.log("Ben yeniden oluşturuldum bana verileri tekrar çek");
    
  }
}
