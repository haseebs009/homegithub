import { EventEmitter, Input, Output } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { CRUDService } from '../crud.service';
import { Employee } from '../employee';
import { EmployeeDetailService } from '../employee-detail.service';
import { EmployeeListService } from '../employee-list.service';
import { Employeedetail } from '../employeedetail';

@Component({
  selector: 'app-employeedetail',
  templateUrl: './employeedetail.component.html',
  styleUrls: ['./employeedetail.component.css']
})
export class EmployeedetailComponent implements OnInit {
  //Input, Output decorators
  @Input() detailEmit: Employeedetail[];
  @Output() empListChanged = new EventEmitter<number>();
  //Variable Declaration
  valueChanger = 1;
  check: boolean = false;
  editClicked: boolean = false;
  empldetail: Employeedetail[];
  editForm: FormGroup;
  EmployeeObject: Employeedetail = new Employeedetail();
  empl: Employee[];
  changeList: number;
  clear: boolean = true;
  //validPattern = "/^[a-zA-Z\_]/";
  constructor(private formbuilder: FormBuilder, private _employeeService: EmployeeListService, private _employeeDetailService: EmployeeDetailService, private _crud: CRUDService) { }
  ngOnInit(): void { }

  Edit(emp: Employeedetail) {
    // console.log(emp);
    this.editForm = new FormGroup({
      id: new FormControl(emp.ID),
      Name: new FormControl(emp.Name, [Validators.required]),
      Designation: new FormControl(emp.Designation, [Validators.required]),
    });

    this.editClicked = true;
  }
  get getName() {
    return this.editForm.controls;
  }

  // Function for Editing
  editpost() {
    this.EmployeeObject.ID = this.editForm.value.id;
    this.EmployeeObject.Name = this.editForm.value.Name;
    this.EmployeeObject.Designation = this.editForm.value.Designation;
    this._crud.editemp(this.EmployeeObject)
      .subscribe();
    this.empListChanged.emit(this.EmployeeObject.ID);
    alert("Edited");
    this.clear = true;
  }
}
