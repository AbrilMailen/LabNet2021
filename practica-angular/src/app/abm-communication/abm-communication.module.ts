import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { FormAltasComponent } from './form-altas/form-altas.component';
import { FormComponent } from './form/form.component';
import { FormModificacionesComponent } from './form-modificaciones/form-modificaciones.component';

import { MatDialogModule } from '@angular/material/dialog';
import { DialogComponent } from '../dialog/dialog.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    FormAltasComponent,
    FormComponent,
    FormModificacionesComponent,
  ],
  entryComponents: [DialogComponent],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatDialogModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      timeOut: 5000,
      progressBar: true,
      progressAnimation: 'decreasing',
    }),
  ],
  exports: [FormAltasComponent],
})
export class ABMCommunicationModule {}
