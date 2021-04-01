import { CompanyserviceService } from './../companyservice.service';
import { Component, OnInit } from '@angular/core';
import { Company } from '../companyservice.model';
import { Companies } from '../companies';

@Component({
  selector: 'app-list-company',
  templateUrl: './list-company.component.html',
  styleUrls: ['./list-company.component.css']
})
export class ListCompanyComponent implements OnInit {

  
  companies: Companies[] = [];
  
  constructor(public CompanyService:CompanyserviceService) { }

  ngOnInit(): void {
    this.CompanyService.getAll().subscribe((data: Companies[])=>{
      console.log(data);
      this.companies=data;
    })  
  }

}
