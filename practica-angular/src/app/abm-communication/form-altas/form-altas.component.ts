import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Employee } from '../models/employee';
import { ServiciosAPIService } from '../services/servicios-api.service';

@Component({
  selector: 'app-form-altas',
  templateUrl: './form-altas.component.html',
  styleUrls: ['./form-altas.component.scss'],
  providers: [ServiciosAPIService]
})
export class FormAltasComponent implements OnInit {
    
    form: FormGroup;
  
    get nombreCtrl(): AbstractControl {
      return this.form.get('FirstName');
    }
  
    get apellidoCtrl(): AbstractControl {
      return this.form.get('LastName');
    }
  
    get tituloCtrl(): AbstractControl{
      return this.form.get('Title');
    }
    get direccionCtrl(): AbstractControl{
      return this.form.get('Address');
    }
    get ciudadCtrl(): AbstractControl{
      return this.form.get('City');
    }
    get regionCtrl(): AbstractControl{
      return this.form.get('Region');
    }
    get codigoPCtrl(): AbstractControl{
      return this.form.get('PostalCode');
    }
    get paisCtrl(): AbstractControl{
      return this.form.get('Country');
    }
    get phoneCtrl(): AbstractControl{
      return this.form.get('HomePhone');
    }

    constructor(private readonly fb: FormBuilder, 
      private serviciosAPIservice: ServiciosAPIService, 
      private toastr: ToastrService) { }
  
    ngOnInit(): void {
      this.form = this.fb.group({
        FirstName: ['', Validators.required],
        LastName: ['', Validators.required],
        Title:['', Validators.maxLength(30)],
        City:['',Validators.maxLength(15)],
        Address:['',Validators.maxLength(60)],
        Region:['',Validators.maxLength(15)],
        PostalCode:['',Validators.maxLength(10)],
        Country:['',Validators.maxLength(15)],
        HomePhone:['',Validators.maxLength(24)]
      });
    }
    save(){
        var employee = new Employee();
        employee.LastName= this.apellidoCtrl.value;
        employee.FirstName=this.nombreCtrl.value;
        employee.Title=this.tituloCtrl.value;
        employee.City=this.ciudadCtrl.value;
        employee.Country=this.paisCtrl.value;
        employee.HomePhone=this.phoneCtrl.value;
        employee.Region=this.regionCtrl.value;
        employee.PostalCode=this.codigoPCtrl.value;
        employee.Address=this.direccionCtrl.value;

        this.serviciosAPIservice.postEmployees(employee).subscribe(
          ()=> {this.toastr.success('¡Empleado agregado con exito!',"Hecho"),  
                this.limpiar()},
          (error:400)=> this.toastr.error('No se puede agregar.','Error')
        );
    }
    limpiar(): void {
     this.form.reset();
    }
  }
