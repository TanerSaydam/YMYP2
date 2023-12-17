import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ExampleProvideService {

  constructor() { }

  degisken: string = "";

  metot(){

  }
}

@Injectable()
export class ExampleNoProvideService {

  constructor() { }
}
