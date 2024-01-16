import { HttpErrorResponse, HttpInterceptorFn } from '@angular/common/http';
import { catchError, of } from 'rxjs';

export const errorInterceptor: HttpInterceptorFn = (req, next) => {
  return next(req).pipe(
    catchError((err:HttpErrorResponse)=> {
      console.log(err);
      switch (err.status) {
        case 400:
          //şunu yap          
          break;
        case 401:
            alert("Bu sayfaya giriş yetkiniz yok!")
            break;
        case 500:   
        //şunu yap       
          break;
      }

      return of();
    })
  );
};
