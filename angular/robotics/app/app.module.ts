import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ArticleDispComponent } from './components/article-disp/article-disp.component';

@NgModule({
  declarations: [
    AppComponent,
    ArticleDispComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
