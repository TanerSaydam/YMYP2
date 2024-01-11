import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'search'
})
export class SearchPipe implements PipeTransform {

  transform(value: string[], p1: string): string[] {
    //console.log("Parametre 1: " + p1);    
    //console.log("Parametre 2: " + p2);    
    //return value.toLocaleLowerCase();
    //return 123;

    return value.filter(p=> p.toLocaleLowerCase().includes(p1.toLocaleLowerCase()));
  }

}
