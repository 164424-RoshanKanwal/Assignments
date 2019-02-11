import { Component } from '@angular/core';
import { UserAccount } from 'userAccount';
import { UserService } from 'user.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-app-register',
  templateUrl: './app-register.component.html'
 /*  styleUrls: ['./app-register.component.css'] */
})
export class AppRegisterComponent  {
  userAccount:UserAccount=new UserAccount();
  
  constructor(private userService: UserService, private _router: Router) { }
  

  

onRegister(){
  console.log("in register() method")
  this.userService.createUser(this.userAccount)
      .subscribe(data => console.log(data), error => console.log(error));
      console.log(this.userAccount)
    this.userAccount = new UserAccount();
    this._router.navigateByUrl('login')
}
}
