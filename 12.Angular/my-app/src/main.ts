import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';
import { TestComponent } from './app/test/test.component';

bootstrapApplication(TestComponent, appConfig)
  .catch((err) => console.error(err));
