import { Component } from '@angular/core';
import { ServiciosAPIService } from './abm-communication/services/servicios-api.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [ServiciosAPIService]
})
export class AppComponent {
  title = 'Practica Angular';
}
