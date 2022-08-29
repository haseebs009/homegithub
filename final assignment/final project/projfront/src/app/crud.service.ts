import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { IDate } from './date';
import { Icountry } from './icountry';
@Injectable({
  providedIn: 'root'
})
export class CrudService {

  constructor(private http: HttpClient) { }
  // Urls for POST and GET methods
  private _urlpost: string = ("http://localhost/projback/postdate")
  private _url: string = ("http://localhost/projback/Getcountry")

  // POST method
  (dateobj: IDate) {
    return this.http.post<number>(this._urlpost, dateobj);
  }Postdetail

  // GET Mrthod
  getCountries(): Observable<Icountry[]> {
    return this.http.get<Icountry[]>(this._url);

  }

}
