import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { DialogComponent } from 'src/app/dialog/dialog.component';
import { Employee } from '../models/employee';
import { ServiciosAPIService } from '../services/servicios-api.service';



@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {
  public employeeResponse: Employee[];


  constructor(private api: ServiciosAPIService, 
    private router: Router, 
    public dialog: MatDialog,
    private toastr: ToastrService)
   { 
    
  }
  modificarId(id:number){
    this.router.navigate(['modificaciones',id]);
  }
  ngOnInit(){
    this.api.getEmployees().subscribe(resp=>{
      this.employeeResponse=resp;
    });
  };
 
  openDialog(employee: Employee) {
    this.dialog.open(DialogComponent, {data: employee});
  }

  eliminar(id:number){
    var r = confirm("¿Usted esta seguro que desea eliminar el empleado "+id+" ?");
    if (r == true) {
      this.api.deleteEmployees(id).subscribe((response:number)=>console.log(response),
      (error:any)=> this.toastr.error('No se puede eliminar.', 'Error'), 
      ()=> this.ngOnInit() //para que se muestren los cambios
      );
    } 
  }
  direccionar(){
    this.router.navigateByUrl('altas');
  }
}
 