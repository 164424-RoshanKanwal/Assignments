import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginAccount } from 'loginAccount';

@Component({
    selector: 'app-login',
    templateUrl: './app-login.component.html'
    /* styleUrls: ['./app-login.component.css'] */
})
export class LoginComponent {
    userService: any;
    loginAccount: any;
    
    constructor(private _router: Router){
    }

    onLogin(){
        console.log("in login() method")
        this.userService.validateUser(this.loginAccount)
        .subscribe(data => console.log(data), error => console.log(error));
        this.loginAccount=new LoginAccount();
      }
}