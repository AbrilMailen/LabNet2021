import { formatCurrency } from '@angular/common';
import { NgModule } from '@angular/core';
import { Router, RouterModule, Routes } from '@angular/router';
import { FormAltasComponent } from './abm-communication/form-altas/form-altas.component';
import { FormModificacionesComponent } from './abm-communication/form-modificaciones/form-modificaciones.component';
import { FormComponent } from './abm-communication/form/form.component';
import { AppComponent } from './app.component';

const routes: Routes = [
  {
    path: '',
    component: AppComponent
  },
  {
    path: 'altas',
    component: FormAltasComponent
  },
  {
    path: 'abm',
    component: FormComponent
  },
  {
    path: 'modificaciones/:id',
    component: FormModificacionesComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule {
}