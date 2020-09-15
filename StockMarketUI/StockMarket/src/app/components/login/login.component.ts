import { Component, OnInit } from '@angular/core';
import { AccountService } from 'src/app/Services/account.service';
import { User } from 'src/app/Models/user';
import { NgForm} from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  user:User = <User>{ };

  constructor(
    private service:AccountService, 
    private router: Router, 
  ) { }

  ngOnInit(): void {
  }
  onSubmit(user:User){
    this.service.Verify(user)
      .subscribe(Response=>{
        localStorage.setItem("session", JSON.stringify(Response));
        this.router.navigateByUrl("");
      });
  }

  public resetForm(){
    this.user = <User>{};
  }
}
