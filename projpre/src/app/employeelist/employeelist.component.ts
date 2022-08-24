import { Employeedetail } from './../employeedetail';
import { EventEmitter, Input } from '@angular/core';
import { Output } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { CRUDService } from '../crud.service';
import { Employee } from '../employee';
import { EmployeeDetailService } from '../employee-detail.service';
import { EmployeeListService } from '../employee-list.service';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-employeelist',
  templateUrl: './employeelist.component.html',
  styleUrls: ['./employeelist.component.css']
})

export class EmployeelistComponent implements OnInit {
  //Input, Output Decorators
  @Output() detailEmit = new EventEmitter<Employeedetail[]>()
  @Input() set changeFun(empListChanged: number) {
    if (empListChanged != null) {
      this._employeeService.getEmployees()
        .subscribe(data => { this.empl = data });

      this._employeeDetailService.getEmployeesByIndex(empListChanged)
        .subscribe(data => {
          this.emplDetail = data;
          this.detailEmit.emit(this.emplDetail);
        }
        );
    }
  }
  //Variable Declaration
  empl: Employee[];
  editClicked: boolean = false;
  emplDetail: Employeedetail[];
  EmployeeObject: Employeedetail = new Employeedetail();

  formValue = new FormGroup({
    enterName: new FormControl('', [Validators.required]),
    Designation: new FormControl('', [Validators.required]),
  });
  constructor(private formbuilder: FormBuilder, private _employeeService: EmployeeListService, private _employeeDetailService: EmployeeDetailService, private _crud: CRUDService) { }
  ngOnInit(): void {

    this._employeeService.getEmployees()
      .subscribe(data => this.empl = data
      );
    this.editClicked = true;
  }
  // Function to show details
  showdetails(ind: number) {
    this._employeeDetailService.getEmployeesByIndex(ind)
      .subscribe(data => {
        this.emplDetail = data;
        this.detailEmit.emit(this.emplDetail);
      }
      );
  }
  // Function for deletion
  Delete(ind: number) {

    this._crud.deleteEmployee(ind)
      .subscribe(data => {
        alert("Deleted");
        this.emplDetail = data;
        this._employeeService.getEmployees()
          .subscribe(data => this.empl = data
          );
      }
      );
  }
  // Function for adding details
  PostEmp() {
    this.EmployeeObject.Name = this.formValue.value.enterName;
    this.EmployeeObject.Designation = this.formValue.value.Designation;
    this._crud.postEmployee(this.EmployeeObject)
      .subscribe(
        data => {
          alert("Details added");
          this.EmployeeObject.Name = this.formValue.value.enterName;
          this.formValue.get('enterName').patchValue('');
          this.formValue.get('Designation').patchValue('');
          this._employeeService.getEmployees()
            .subscribe(data => this.empl = data
            );
        }
      );
  }
}


