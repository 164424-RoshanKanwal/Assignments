import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './app-login.component.html'
    /* styleUrls: ['./app-login.component.css'] */
})
export class LoginComponent {
    public get router(): Router {
        return this._router;
    }
    public set router(value: Router) {
        this._router = value;
    }
    constructor(private _router: Router){
    }

    public onLoginClick(){
        this.router.navigate(['./home']);
    }
}