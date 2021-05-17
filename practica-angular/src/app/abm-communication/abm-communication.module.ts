import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { FormAltasComponent } from './form-altas/form-altas.component';
import { FormComponent } from './form/form.component';
import { FormModificacionesComponent } from './form-modificaciones/form-modificaciones.component';

import {MatDialogModule} from '@angular/material/dialog';
import { DialogComponent } from '../dialog/dialog.component';


@NgModule({
  declarations: [
    FormAltasComponent,
    FormComponent,
    FormModificacionesComponent
  ],
  entryComponents:[DialogComponent],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatDialogModule
  ],
  exports: [
    FormAltasComponent
  ]
})
export class ABMCommunicationModule { }
