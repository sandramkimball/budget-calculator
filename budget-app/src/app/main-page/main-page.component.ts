import { Component, OnInit } from '@angular/core';
import { BudgetItem } from 'src/shared/models/budget-item.model';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss']
})
export class MainPageComponent implements OnInit {

  // Init the array
  budgetItems: BudgetItem[] = new Array<BudgetItem>()
  constructor() { }

  ngOnInit(): void {
  }

  // Like onChange sets state
  addItem(newItem: BudgetItem){
    this.budgetItems.push(newItem);
  }

  /*Notes
    (formSubmit)='addItem($event)'

    -event binding keyword 'formSubmit', 
    which is the EventEmitter in form.component
    -set equal to addItem()
    -pass in values with ($event)
  */
}
