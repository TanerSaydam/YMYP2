import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-table',
  standalone: true,
  imports: [],
  template:`
  <table class="table table-hover table-bordered">
    <thead>
      <tr>
        @for(header of headers; track header){
          <th>
          {{header.name}}
          @if(!header.desc){
            <i class="fa-solid fa-arrow-up-wide-short"></i>
          }@else{
            <i class="fa-solid fa-arrow-up-short-wide"></i>
          }
        </th>  
        }            
      </tr>
    </thead>
    <tbody>
     <ng-content></ng-content>
    </tbody>
  </table>  
  `
})
export class TableComponent {
  @Input() headers: {name: string, desc: boolean}[] = []
}
