import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ServiciosAPIService } from '../services/servicios-api.service';

@Component({
  selector: 'app-form-modificaciones',
  templateUrl: './form-modificaciones.component.html',
  styleUrls: ['./form-modificaciones.component.scss'],
  providers: [ServiciosAPIService],
})
export class FormModificacionesComponent implements OnInit {
  formModificar = new FormGroup({
    Id: new FormControl(''),
    FirstName: new FormControl('', Validators.required),
    LastName: new FormControl('', Validators.required),
    Title: new FormControl('', Validators.maxLength(30)),
    City: new FormControl('', Validators.maxLength(15)),
    Address: new FormControl('', Validators.maxLength(60)),
    Region: new FormControl('', Validators.maxLength(15)),
    PostalCode: new FormControl('', Validators.maxLength(10)),
    Country: new FormControl('', Validators.maxLength(15)),
    HomePhone: new FormControl('', Validators.maxLength(24)),
  });

  get nombreCtrl(): AbstractControl {
    return this.formModificar.get('FirstName');
  }
  get idCtrl(): AbstractControl {
    return this.formModificar.get('Id');
  }
  get apellidoCtrl(): AbstractControl {
    return this.formModificar.get('LastName');
  }
  get tituloCtrl(): AbstractControl {
    return this.formModificar.get('Title');
  }
  get direccionCtrl(): AbstractControl {
    return this.formModificar.get('Address');
  }
  get ciudadCtrl(): AbstractControl {
    return this.formModificar.get('City');
  }
  get regionCtrl(): AbstractControl {
    return this.formModificar.get('Region');
  }
  get codigoPCtrl(): AbstractControl {
    return this.formModificar.get('PostalCode');
  }
  get paisCtrl(): AbstractControl {
    return this.formModificar.get('Country');
  }
  get phoneCtrl(): AbstractControl {
    return this.formModificar.get('HomePhone');
  }
  constructor(
    private readonly fb: FormBuilder,
    private serviciosAPIservice: ServiciosAPIService,
    private activeRouter: ActivatedRoute,
    private router: Router,
    private toastr: ToastrService
  ) {}

  ngOnInit(): void {
    let employeeId = this.activeRouter.snapshot.paramMap.get('id');
    var id = parseInt(employeeId);
    this.serviciosAPIservice.getEmployee(id).subscribe((json) => {
      this.idCtrl.setValue(json.Id);
      this.nombreCtrl.setValue(json.FirstName);
      this.apellidoCtrl.setValue(json.LastName);
      this.paisCtrl.setValue(json.Country);
      this.phoneCtrl.setValue(json.HomePhone);
      this.ciudadCtrl.setValue(json.City);
      this.regionCtrl.setValue(json.Region);
      this.tituloCtrl.setValue(json.Title);
      this.direccionCtrl.setValue(json.Address);
      this.codigoPCtrl.setValue(json.PostalCode);
    });
  }

  modificar() {
    this.serviciosAPIservice.putEmployees(this.formModificar.value).subscribe(
      () => {
        this.toastr.success('¡Empleado modificado con exito!', 'Hecho');
        this.router.navigateByUrl('abm');
      },
      (error: HttpErrorResponse) =>
        this.toastr.error('No se pudo modificar.', 'Error')
    );
  }

  direccionar() {
    if (this.formModificar.valid) {
      var res = confirm(
        '¿Esta seguro que desea salir? Se perderán todos los cambios.'
      );
      if (res) {
        this.router.navigateByUrl('abm');
      }
    } else {
      this.router.navigateByUrl('abm');
    }
  }
}
