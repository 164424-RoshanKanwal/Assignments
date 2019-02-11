import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { LoginComponent } from './component/app-login/app-login.component';
import { HomeComponent } from './component/app-home/app-home.component';
import { Route, RouterModule } from '@angular/router';
import { AppRegisterComponent } from './component/app-register/app-register.component';
import { FormsModule } from '@angular/forms';
@NgModule({
  declarations: [
    AppComponent,

    LoginComponent,
    HomeComponent,
    AppRegisterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    
  ],
  providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy}],
  bootstrap: [AppComponent]
})
export class AppModule { }















 
 

