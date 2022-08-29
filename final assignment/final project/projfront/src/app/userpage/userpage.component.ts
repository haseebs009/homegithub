import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { CrudService } from '../crud.service';
import { IDate } from '../date';
import { Icountry } from '../icountry';

@Component({
  selector: 'app-userpage',
  templateUrl: './userpage.component.html',
  styleUrls: ['./userpage.component.css']
})
export class UserpageComponent implements OnInit {

  // Variable declaration
  countryData: Icountry[] = [];
  incommingData: number;
  dateObject: IDate = new IDate();

  constructor(private _crud: CrudService) { }
  ngOnInit(): void {
    // Getting country list from DB via API
    this._crud.getCountries()
      .subscribe(data => { this.countryData = data });
  }
  formValue = new FormGroup({
    startDate: new FormControl(null, [Validators.required]),
    endDate: new FormControl(null, [Validators.required]),
    CountryName: new FormControl('', [Validators.required])
  });

  // Method to post dates in API and get response
  Postdetail() {

    this.dateObject.StartDate = this.formValue.value.startDate;
    this.dateObject.EndDate = this.formValue.value.endDate;
    this.dateObject.Country = this.formValue.value.CountryName;
    this._crud.Postdetail(this.dateObject)
      .subscribe(data =>
        this.incommingData = data
      );
  }


}
