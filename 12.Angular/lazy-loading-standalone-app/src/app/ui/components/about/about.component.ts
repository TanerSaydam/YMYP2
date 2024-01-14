import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [],
  templateUrl: './about.component.html',
  styleUrl: './about.component.css'
})
export default class AboutComponent {
  p1: string = "";
  p2: string = "";
  p3: string = "";

  constructor(
    private acitvated: ActivatedRoute
  ){
    this.acitvated.queryParams.subscribe(res=> {
      console.log(res);
      
    })
    // this.acitvated.params.subscribe(res=> {
    //   console.log(res);
    //   this.p1 = res["p1"];
    //   this.p2 = res["p2"];
    //   this.p3 = res["p3"];

    //   console.log(this.p1);
    //   console.log(this.p2);
    //   console.log(this.p3);
      
    // })
  }
}
