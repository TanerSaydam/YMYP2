import { HttpErrorResponse, HttpInterceptorFn } from '@angular/common/http';
import { catchError, of } from 'rxjs';

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  const cloneReq = req.clone({
    headers: req.headers.set("secretkey2", "Taner Saydam")
  });

  return next(cloneReq);
};
