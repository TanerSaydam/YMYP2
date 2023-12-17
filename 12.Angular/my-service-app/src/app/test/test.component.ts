import { Component } from '@angular/core';
import { ExampleProvideService } from '../example.service';

@Component({
  selector: 'app-test',
  standalone: true,
  imports: [],
  templateUrl: './test.component.html',
  styleUrl: './test.component.css'
})
export class TestComponent {
  test: string = "";

  constructor(
    public service: ExampleProvideService
  ){
    this.test = this.service.degisken;
  }
}
