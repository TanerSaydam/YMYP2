import { HttpInterceptorFn } from '@angular/common/http';

export const authInterceptor: HttpInterceptorFn = (req, next) => {
  const token: string = localStorage.getItem("token") ?? "";

  const clone = req.clone({
    headers: req.headers.append("SecretKey",token)
  })
  return next(clone);
};
