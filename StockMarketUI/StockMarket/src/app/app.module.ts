import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { CompanyComponent } from './components/company/company.component';
import { AdminService } from './services/admin.service';
import {FormsModule} from "@angular/forms";
import { NavbarComponent } from './components/navbar/navbar.component';
import { AccountService } from './Services/account.service';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SignupComponent,
    CompanyComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [AdminService,
    AccountService,],
  bootstrap: [AppComponent]
})
export class AppModule { }
