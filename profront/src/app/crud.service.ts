import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { IDate } from './date';
@Injectable({
  providedIn: 'root'
})
export class CrudService {

  constructor(private http: HttpClient) { }
  private _urlpost: string = ("http://localhost/projback/postdate")
  Postdetail(dateobj: IDate) {
    return this.http.post<number>(this._urlpost, dateobj);
  }

}
