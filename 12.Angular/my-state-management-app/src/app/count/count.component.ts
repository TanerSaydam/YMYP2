import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-count',
  standalone: true,
  imports: [],
  template: `
  <h1>Number: {{count2}}</h1>
  `
})
export class CountComponent {
@Input() count2: number = 0;
}
