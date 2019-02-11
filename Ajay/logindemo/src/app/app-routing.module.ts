import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { LoginComponent } from './component/app-login/app-login.component';
import { HomeComponent } from './component/app-home/app-home.component';
import { AppRegisterComponent } from './component/app-register/app-register.component';

const ROUTES: Route[] = [
  { path: '', component: LoginComponent},
  { path: 'home', component: HomeComponent},
  // { path: "login", component: LoginComponent},
  {path: 'register', component: AppRegisterComponent}
 
]

@NgModule({
  imports: [RouterModule.forRoot(ROUTES)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
