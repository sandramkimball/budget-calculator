import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { BudgetItem } from '../../shared/models/budget-item.model';

@Component({
  selector: 'app-budget-item-list',
  templateUrl: './budget-item-list.component.html',
  styleUrls: ['./budget-item-list.component.scss']
})
export class BudgetItemListComponent implements OnInit {

  // In order to conditionally render budget items, need to create array of data 
  // using the imported model
  @Input() budgetItems: BudgetItem[];

  // Parent needs to know what item, so <BudgetItem> rather than <any>
  @Output() delete: EventEmitter<BudgetItem> = new EventEmitter<BudgetItem>();

  constructor() { }

  ngOnInit(): void {
  }

  //sends item as the event data
  onDelete(item: BudgetItem){
    this.delete.emit(item);
    console.log('Delete from item list', item)
  }

  /* Notes:
    *ngIf='item.amount < 0'

    this is a conditional render, 
    if statement that auto .maps()
    will only show items if < 0
   */

}
