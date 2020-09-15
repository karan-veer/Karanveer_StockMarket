import { Component, OnInit } from '@angular/core';
import { AccountService } from '../../services/account.service';
import { User } from 'src/app/Models/user';
import { NgForm} from '@angular/forms';
import { Router } from '@angular/router'; 

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
  User:User = <User>{};
  form:NgForm;
  constructor(
    private service:AccountService, 
    private router: Router
  ) { }

  ngOnInit(): void {
  }
  onSubmit(){
  this.service.Add(this.form.value)
  .subscribe(() => {
      this.router.navigateByUrl("login");
  });
}
}

