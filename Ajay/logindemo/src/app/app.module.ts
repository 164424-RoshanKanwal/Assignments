import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AppRegisterComponent } from './component/app-register/app-register.component';
import { LoginComponent } from './component/app-login/app-login.component';
import { HomeComponent } from './component/app-home/app-home.component';
import { Route, RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    AppComponent,
    AppRegisterComponent,
    LoginComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
