import { Pipe, PipeTransform } from '@angular/core';
import { PersonelModel } from '../models/personel.model';

@Pipe({
  name: 'personel',
  standalone: true
})
export class PersonelPipe implements PipeTransform {

  transform(value: PersonelModel[],filter: string): PersonelModel[] {
    if(filter === "")
      return value;

    const result = value.filter(p=> 
      p.firstName.toLocaleLowerCase().includes(filter.toLocaleLowerCase()) ||
      p.lastName.toLocaleLowerCase().includes(filter.toLocaleLowerCase()) ||
      p.profession.toLocaleLowerCase().includes(filter.toLocaleLowerCase()));
     
    return result;
  }

}
