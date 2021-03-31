import { Component, OnInit } from '@angular/core';
import { Company } from '../companyservice.model';
import { CompanyserviceService } from '../companyservice.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Validators, FormControl } from '@angular/forms';

@Component({
  selector: 'app-edit-company',
  templateUrl: './edit-company.component.html',
  styleUrls: ['./edit-company.component.css']
})
export class EditCompanyComponent implements OnInit {
  Id!:any;
  companies:Company[]=[];
  company:any;
  flag:boolean=false;

  constructor(private CompanyService:CompanyserviceService,private router:Router,private route:ActivatedRoute) { }

  RequiredValidationName= new FormControl('',[
    Validators.required
  ]);  


  ngOnInit(): void {

  }

  OnSubmit(){
   
  }

}
