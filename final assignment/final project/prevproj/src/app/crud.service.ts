import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Employeedetail } from './employeedetail';

@Injectable({
  providedIn: 'root'
})
export class CRUDService {
//Urls for crud requests
  private _urlput: string = ("http://localhost/empbackend/update")
  private _urldel: string = ("http://localhost/empbackend/delete?id=")
  private _urlpost: string = ("http://localhost/empbackend/postemp")
  constructor(private http: HttpClient) { }
//Crud Functions
   deleteEmployee(index: number): Observable<any> {
    let x = this.http.delete<any>(this._urldel + index);
    return x;
  }
  postEmployee(EmployeeObject: Employeedetail) {
    return this.http.post<Employeedetail>(this._urlpost, EmployeeObject);
  }
  editemp(EmployeeObject: Employeedetail){
    return this.http.put<Employeedetail>(this._urlput, EmployeeObject);
  }
}
