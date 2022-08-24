import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Employee } from './employee';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class EmployeeListService {
  private _url: string = "http://localhost/empbackend/EmpList"
  constructor(private http: HttpClient) { }
  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this._url);
  }
}
