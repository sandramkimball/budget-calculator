import { Component, OnInit, Input } from '@angular/core';
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

  constructor() { }

  ngOnInit(): void {
  }

  /* 
    *ngIf='item.amount < 0'

    this is a conditional render, 
    if statement that auto .maps()
    will only show items if < 0
   */

}
