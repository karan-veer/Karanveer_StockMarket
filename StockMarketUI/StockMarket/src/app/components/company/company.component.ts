import { Component, OnInit } from '@angular/core';
import { Company } from '../../Models/company';
import { AdminService } from '../../services/admin.service';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {
  list:Company[];
  companyCode:string;
  companyName:string;
  ceo:string;
  obj:Company;

  constructor(private service:AdminService) {
    this.service.GetAll().subscribe(i=>{
      this.list=i;
      console.log(this.list);
    });
   }

  ngOnInit(): void {
  }
  public Search(){
    this.service.Get(this.companyCode).subscribe(item=>{
      this.obj=item;
      console.log(this.obj);
      this.companyCode = this.obj.companyCode;
      this.companyName = this.obj.companyName;
      this.ceo = this.obj.ceo;
    })
  }
  public Add(){
    this.obj = {
      companyCode:this.companyCode,
      companyName:this.companyName,
      ceo:this.ceo,
    };
    this.service.Add(this.obj).subscribe(i=>{
      console.log(i);
    })
  }
  public Update(){
    this.obj = {
      companyCode:this.companyCode,
      companyName:this.companyName,
      ceo:this.ceo,
    };
    this.service.Update(this.obj).subscribe(i=>{
      console.log(i);
    })
  }
  public Delete(){
    this.service.Delete(this.companyCode).subscribe(res=>{
      console.log(res);
    })
  }
}
