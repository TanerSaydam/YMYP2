import { HttpInterceptorFn } from '@angular/common/http';

export const testInterceptor: HttpInterceptorFn = (req, next) => {
  const clone = req.clone({
    headers: req.headers.set("secretkey","Taner Saydam")
  })
  return next(clone);
};
