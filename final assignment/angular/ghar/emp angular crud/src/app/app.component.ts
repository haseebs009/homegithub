import { Component } from '@angular/core';
import { Employeedetail } from './employeedetail';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'project1';
  Employeedetail: Employeedetail[];
  changeList: number;
}
