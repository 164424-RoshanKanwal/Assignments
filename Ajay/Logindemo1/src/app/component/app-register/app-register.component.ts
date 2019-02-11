import { Component } from '@angular/core';
import { UserAccount } from 'userAccount';
import { UserService } from 'user.service';


@Component({
  selector: 'app-app-register',
  templateUrl: './app-register.component.html'
 /*  styleUrls: ['./app-register.component.css'] */
})
export class AppRegisterComponent  {
  userAccount:UserAccount=new UserAccount();
  
  constructor(private userService: UserService) { }
  

  

onRegister(){
  console.log("in register() method")
  this.userService.createUser(this.userAccount)
      .subscribe(data => console.log(data), error => console.log(error));
    this.userAccount = new UserAccount();
}
}
