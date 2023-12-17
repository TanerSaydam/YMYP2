import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { IConfig, provideEnvironmentNgxMask } from 'ngx-mask';

const maskConfig: Partial<IConfig> = {
  validation: false,
  
};

export const appConfig: ApplicationConfig = {
  providers: [provideRouter(routes), provideEnvironmentNgxMask(maskConfig)]
};
