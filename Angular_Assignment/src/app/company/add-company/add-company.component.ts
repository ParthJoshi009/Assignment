import { Component, OnInit } from '@angular/core';
import { CompanyserviceService } from '../companyservice.service';
import { Company } from '../companyservice.model';
import { ActivatedRoute, Router, Route } from '@angular/router';
import { FormGroup, FormBuilder, FormControl, Validators, NgForm } from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import { Companies } from '../companies';
import { ReactiveFormsModule } from '@angular/forms';
import { LoadScript } from 'src/app/load-script';


@Component({
  selector: 'app-add-company',
  templateUrl: './add-company.component.html',
  styleUrls: ['./add-company.component.css']
})
export class AddCompanyComponent implements OnInit {
  
  company!: Companies;
  companyForm!: FormGroup;
  matcher = new ErrorStateMatcher();
  constructor(private loadscript:LoadScript,private CompanyService:CompanyserviceService, public fb: FormBuilder,private router: Router) { }
  get name(): FormControl{
    return this.companyForm.get('name') as FormControl;
  }
  get email(): FormControl{
    return this.companyForm.get('email') as FormControl;
  }
  get totalEmployee(): FormControl{
    return this.companyForm.get('totalEmployee') as FormControl;
  }
  get address(): FormControl{
    return this.companyForm.get('address') as FormControl;
  }
  get totalBranch(): FormControl{
    return this.companyForm.get('totalBranch') as FormControl;
  }
  get branchId(): FormControl{
    return this.companyForm.get('branchId') as FormControl;
  }
  get branchName(): FormControl{
    return this.companyForm.get('branchName') as FormControl;
  }
  get branchaddress(): FormControl{
    return this.companyForm.get('branchaddress') as FormControl;
  }
  
  // CompanyName = new FormControl('',[
  //   Validators.required,
  // ]);
  // companyForm: FormGroup = new FormGroup({
  //   name : this.CompanyName
  // });
    ngOnInit(): void {
      this.loadscript.run2("app-add-company");
      this.companyForm = this.fb.group({
        name: ['',Validators.required],
        email: ['',Validators.required,Validators.email],
        totalEmployee: ['',[Validators.required]],
        address:['',Validators.required],
        isCompanyActive:[''],
        totalBranch:['',Validators.required],
        branchId:['',Validators.required],
        branchName: ['',Validators.required],
        branchaddress: ['',Validators.required]
      })  
  }
    submitForm() {
      
      this.CompanyService.create(this.companyForm.value).subscribe(res => {
        console.log('Company created!')
        this.router.navigate(['/ListCompany'])
        })
    }
    
  }
