import { CompanyserviceService } from './../companyservice.service';
import { Component, OnInit } from '@angular/core';
import { Company } from '../companyservice.model';
import { Companies } from '../companies';
import { Router } from '@angular/router';
import Swal from 'sweetalert2'
import { LoadScript } from 'src/app/load-script';

@Component({
  selector: 'app-list-company',
  templateUrl: './list-company.component.html',
  styleUrls: ['./list-company.component.css']
})
export class ListCompanyComponent implements OnInit {

  
  companies: Companies[] = [];
  id:any;  

  constructor(private loadscript:LoadScript,public CompanyService:CompanyserviceService, private router:Router) { }

  ngOnInit(): void {
    this.loadscript.run2("app-list-company");
  //  this.call()
  this.CompanyService.getAll().subscribe((data: Companies[])=>{
    console.log(data);
    this.companies=data;
  })  
  }

    Delete(Id:number)
    {
      Swal.fire({
        title: 'Are you sure?',
        text: 'Its Delete!',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Yes, delete it!',
        cancelButtonText: 'No, keep it'
      }).then((result)=>{
        if(result.value){
          this.CompanyService.delete(Id).subscribe((res:any)=>{
            console.log(Id,'Company Deleted');
              Swal.fire(
                'Deleted!',
                'Company has been deleted.',
                'success'
              )
          });
        }
        else if (result.dismiss === Swal.DismissReason.cancel) {
          Swal.fire(
            'Cancelled',
            'Company present! :)',
            'error'
          )
        }
      })   
    }
    // call()
    // {
    //   this.CompanyService.getAll().subscribe((data: Companies[])=>{
    //     console.log(data);
    //     this.companies=data;
    //   })  
    // }
}
