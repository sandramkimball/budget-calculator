import { Component, OnInit } from '@angular/core';
import { BudgetItem } from 'src/shared/models/budget-item.model';
import { UpdateEvent } from '../budget-item-list/budget-item-list.component';


@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss']
})


export class MainPageComponent implements OnInit {

  // Init the array
  budgetItems: BudgetItem[] = new Array<BudgetItem>();
  totalBudget: number = 0;

  // Inject local storage
  constructor() {}

  ngOnInit(): void {
  }

  // Like onChange sets state
  addItem(newItem: BudgetItem){
    this.budgetItems.push(newItem);
    this.totalBudget += newItem.amount;
  }

  // finally delete item passed up from children(item-list, item-card)
  deleteItem(item: BudgetItem){
    let index = this.budgetItems.indexOf(item)
    this.budgetItems.splice(index, 1)
    this.totalBudget -= item.amount
  }

  updateItem(updateEvent: UpdateEvent){
    this.budgetItems[this.budgetItems.indexOf(updateEvent.old)] = updateEvent.new
    this.totalBudget -= updateEvent.old.amount
    this.totalBudget += updateEvent.new.amount
  }

  /*Notes
    (formSubmit)='addItem($event)'

    -event binding keyword 'formSubmit', 
    which is the EventEmitter in form.component
    -set equal to addItem()
    -pass in values with ($event)
  */
}
