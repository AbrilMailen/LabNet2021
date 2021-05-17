import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee, EmployeeResumido } from '../models/employee';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServiciosAPIService {

  
  constructor(private http: HttpClient) { }

  postEmployees(request: Employee)
  {
    return this.http.post(environment.api_ABM + 'Employees/', request);
  }
  
  getEmployee(id: number):Observable<Employee>{
  return this.http.get<Employee>(environment.api_ABM +'Employees/'+ id);
}


  getEmployees():Observable<EmployeeResumido[]>  
  {
   return this.http.get<EmployeeResumido[]>(environment.api_ABM +'Employees/');
  }

  deleteEmployees(id: number){
    return this.http.delete(environment.api_ABM +'Employees/'+ id);
  }

 putEmployees(body: Employee){
   return this.http.put(environment.api_ABM + 'Employees/', body);
 }
}
