import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';
import { AboutComponent } from './app/about/about.component';

bootstrapApplication(AboutComponent, appConfig)
  .catch((err) => console.error(err));
