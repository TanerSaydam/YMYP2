import { CanDeactivateFn } from '@angular/router';
import { AboutComponent } from './about/about.component';

export const authGuard: CanDeactivateFn<AboutComponent> = (component, currentRoute, currentState, nextState) => {  
  
 const result = confirm("Sayfadan çıkmak istiyor musunuz?");

 return result;
};

// guard eskiden authentication kontrolü için kullanılıyordu
//angular 16 17 ile artık kullnılmıyor
//guard'ın kullanılan tek fonsiyonu candeactive
//o da sayfanın çıkış işlemini kontrol ediyor

// Component
// Directive
// Pipe
// Service
// Guard
