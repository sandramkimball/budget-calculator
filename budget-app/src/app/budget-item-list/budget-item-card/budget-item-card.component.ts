import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { BudgetItem } from '../../../shared/models/budget-item.model'

@Component({
  selector: 'app-budget-item-card',
  templateUrl: './budget-item-card.component.html',
  styleUrls: ['./budget-item-card.component.scss']
})
export class BudgetItemCardComponent implements OnInit {

  // In order to render the input values
  @Input() item: BudgetItem;
  //<any> or <void> because we're not sending new data, we're sending already bound data
  @Output() xButtonClick: EventEmitter<any> = new EventEmitter<any>();
  @Output() cardClick: EventEmitter<any> = new EventEmitter<any>();

  constructor() { }

  ngOnInit(): void {
  }

  // not the actual delete method
  // sends item up to parent (list) to send up (mainpage) to be deleted
  onXButtonClick(){
    // emit an event
    this.xButtonClick.emit();
  }

  onCardClick(){
    this.cardClick.emit();
  }

}
