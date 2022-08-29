import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-userpage',
  templateUrl: './userpage.component.html',
  styleUrls: ['./userpage.component.css']
})
export class UserpageComponent implements OnInit {
  formValue = new FormGroup({
    enterName: new FormControl('', [Validators.required]),
    Designation: new FormControl('', [Validators.required]),
  });
  EmployeeObject = new
    constructor() { }

ngOnInit(): void {
}
dateObject: Date = new Date();
PostEmp() {
  this.dateObject.ID = this.editForm.value.id;
  this.dateObject.Name = this.editForm.value.Name;
  // this._crud.editemp(this.EmployeeObject)
  //   .subscribe();
  // this.empListChanged.emit(this.EmployeeObject.ID);
  // alert("Edited");
  // this.clear = true;
}
}
