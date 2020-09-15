import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs"; 
import { Company } from '../Models/company';
import {User} from '../Models/user';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  path:string = "http://localhost:58909/Account/";
  constructor(private http:HttpClient) { }
  public Verify(user:User):Observable<any>
  {
    return this.http.post<any>(`${this.path}/Account/Validate`, user);
  }
  public Add(item:User):Observable<any>{
    console.log(item);
    return this.http.post<any>(this.path+"AddUser",item);
  }
  public Update(item:User):Observable<any>{
    console.log(item);
    return this.http.put<any>(this.path+"UpdateUser",item);
  }
  
}
