import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import ProductListView from './views/productListView.components';
import { Store } from './services/store.service';

@NgModule({
  declarations: [
        AppComponent,
        ProductListView
  ],
  imports: [
      BrowserModule,
      HttpClientModule
  ],
    providers: [
        Store
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
