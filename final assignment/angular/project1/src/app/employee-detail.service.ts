import { HttpClient } from '@angular/common/http';
import { Input } from '@angular/core';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Employeedetail } from './employeedetail';

@Injectable({
  providedIn: 'root'
})
export class EmployeeDetailService {
  private _urlid: string = ("http://localhost/empbackend/EmpDetail?id=")
  constructor(private http: HttpClient) { }
  getEmployeesByIndex(index: number): Observable<Employeedetail[]> {
    let x = this.http.get<Employeedetail[]>(this._urlid + index);
      return x;
  }
}
