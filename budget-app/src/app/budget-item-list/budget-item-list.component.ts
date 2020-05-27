import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { BudgetItem } from '../../shared/models/budget-item.model';
import { MatDialog } from '@angular/material/dialog';
import { EditItemModalComponent } from '../edit-item-modal/edit-item-modal.component'

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
  //for purpose of updating total price:
  @Output() update: EventEmitter<UpdateEvent> = new EventEmitter<UpdateEvent>();

  constructor( public dialog: MatDialog ) {  }

  ngOnInit(): void {
  }

  //sends item as the event data
  onDelete(item: BudgetItem){
    this.delete.emit(item);
  }

  onCardClick(item: BudgetItem){
    //show the edit modal
    //create dialog obj and inject into component
    const dialogRef = this.dialog.open(EditItemModalComponent, {
      width: '580px',
      data: item
    })

    //subscribe to event when closed
    dialogRef.afterClosed().subscribe(result=>{
      //replace item with updated item
      if(result){
        this.update.emit({
          old: item,
          new: result
        })
      }
    })
  }
 
}

export interface UpdateEvent {
  old: BudgetItem;
  new: BudgetItem;
}
