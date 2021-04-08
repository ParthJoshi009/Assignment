import { Component, OnInit } from '@angular/core';
import { CompanyserviceService } from '../companyservice.service';
import { Company } from '../companyservice.model';
import { Companies } from '../companies';
import { Router, ActivatedRoute } from '@angular/router';
import { LoadScript } from 'src/app/load-script';

@Component({
  selector: 'app-view-company',
  templateUrl: './view-company.component.html',
  styleUrls: ['./view-company.component.css']
})
export class ViewCompanyComponent implements OnInit {
  id:any;
  //company:Company=new Company();
  companies!: Companies;
  

  constructor(private loadscript:LoadScript,private CompanyService:CompanyserviceService, private router:Router, private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.loadscript.run2("app-view-company");
    this.id = this.route.snapshot.paramMap.get('id');
    this.CompanyService.getById(this.id).subscribe((data)=>{
      this.companies=data;
      console.log("++",data)
      });
  }

}
