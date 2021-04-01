import { Component, OnInit } from '@angular/core';
import { CompanyserviceService } from '../companyservice.service';
import { Company } from '../companyservice.model';
import { ActivatedRoute, Router, Route } from '@angular/router';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-add-company',
  templateUrl: './add-company.component.html',
  styleUrls: ['./add-company.component.css']
})
export class AddCompanyComponent implements OnInit {
  companyForm!: FormGroup;
  constructor(private CompanyService:CompanyserviceService, public fb: FormBuilder,private router: Router,) { }

  ngOnInit(): void {
    this.companyForm = this.fb.group({
      name: [''],
      email: [''],
      totalEmployee: [''],
      address:[''],
      isCompanyActive:[''],
      totalBranch:['']
    })
  }
 
    submitForm() {
      this.CompanyService.create(this.companyForm.value).subscribe(res => {
        console.log('Company created!')
        this.router.navigateByUrl('/ListCompany')
        })
    }
  }
