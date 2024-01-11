import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BlogComponent } from './blog/blog.component';
import { MyDirectiveDirective } from './my-directive.directive';
import { SearchPipe } from './search.pipe';
import { FormsModule } from '@angular/forms';
import { ExampleModule } from './example/example.module';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [ //buraya component, directive ve pipe eklenir
    AppComponent,    
    BlogComponent,    
    SearchPipe
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ExampleModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
