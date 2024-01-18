import { HttpErrorResponse, HttpInterceptorFn } from '@angular/common/http';
import { catchError, of } from 'rxjs';

export const errorInterceptor: HttpInterceptorFn = (req, next) => {
  return next(req).pipe(
    catchError((err: HttpErrorResponse)=> {
      console.log(err.error.errorMessage);
      
      switch (err.status){
        case 401:
        alert("You are trying to access a page for which you are not authorized!")
      }

      return of();
    })
  );
};
