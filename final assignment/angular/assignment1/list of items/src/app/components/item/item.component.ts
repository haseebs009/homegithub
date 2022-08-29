import { Component, OnInit } from '@angular/core';
import { item } from '../../models/item';

@Component({
  selector: 'app-items',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class itemsComponent implements OnInit {
  // Defining Variables
  items:item[];
  inputitem:string = "";

  constructor() { }

  ngOnInit(): void {
    this.items = [

    ]
  }
  // Function to add items in items array
  additem () {
    this.items.push({
      content: this.inputitem,
    });
    // To clear the field as its a two way binding
    this.inputitem = "";
  }

}
