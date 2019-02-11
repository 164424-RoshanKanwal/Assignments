import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginAccount } from 'loginAccount';
import { UserService } from 'user.service';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';
import { UserAccount } from 'userAccount';

@Component({
    selector: 'app-login',
    templateUrl: './app-login.component.html'
    /* styleUrls: ['./app-login.component.css'] */
})
export class LoginComponent {
    
      
      constructor(private fb: FormBuilder,private route:Router,private userService: UserService) { }
      loginForm: FormGroup;
    
      loginAccount:LoginAccount=new LoginAccount();
      userAccount:UserAccount=new UserAccount();
      ngOnInit() {
        this.loginForm=this.fb.group(
    {
      email:['',[ Validators.required,Validators.pattern('^[a-zA-Z0-9_.+-]+@gmail.com+$')] ],
      password:['',[Validators.required,Validators.maxLength(15),Validators.minLength(6)]]
    
    })
      }
      onLogin(){
        console.log("in login() method")
        console.log(this.loginAccount)
          this.userService.validateUser(this.loginAccount)
          .subscribe(data => console.log(data), error => console.log(error));
          this.loginAccount=new LoginAccount();
          console.log(this.loginAccount)
        this.route.navigateByUrl("home");
         }
    
}