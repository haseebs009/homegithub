import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { CrudService } from '../crud.service';
import { IDate } from '../date';

@Component({
  selector: 'app-userpage',
  templateUrl: './userpage.component.html',
  styleUrls: ['./userpage.component.css']
})
export class UserpageComponent implements OnInit {

  dateObject: IDate = new IDate();
  Country: any = ['Pakistan', 'UAE'];


  constructor(private _crud: CrudService) { }

  ngOnInit(): void {
  }
  formValue = new FormGroup({
    startDate: new FormControl(),
    endDate: new FormControl(),
    CountryName:new FormControl()
  });
  incommingData:number;
  Postdetail() {
    this.dateObject.StartDate = this.formValue.value.startDate;
    this.dateObject.EndDate = this.formValue.value.endDate;
    this.dateObject.Country= this.formValue.value.CountryName;
    this._crud.Postdetail(this.dateObject)
    .subscribe(data => 
     this.incommingData = data
     //console.log(data)
 );
 console.log(this.incommingData);
  // this.empListChanged.emit(this.EmployeeObject.ID);
  alert("posted");
}


}
