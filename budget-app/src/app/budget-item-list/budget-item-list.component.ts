import { Component, OnInit, Input, Output, EventEmitter, Injectable } from '@angular/core';
import { BudgetItem } from '../../shared/models/budget-item.model';
import { MatDialog } from '@angular/material/dialog';
import { EditItemModalComponent } from '../edit-item-modal/edit-item-modal.component'

// for LocalStorage
import { NgModule } from '@angular/core';
import { StorageServiceModule } from 'ngx-webstorage-service';
import { Injectable, Inject } from '@angular/core';
import { LOCAL_STORAGE, StorageService } from 'ngx-webstorage-service';

@Component({
  selector: 'app-budget-item-list',
  templateUrl: './budget-item-list.component.html',
  styleUrls: ['./budget-item-list.component.scss']
})

@Injectable()

export class BudgetItemListComponent implements OnInit {
  // In order to conditionally render budget items, need to create array of data 
  // using the imported model
  @Input() budgetItems: BudgetItem[];

  // Parent needs to know what item, so <BudgetItem> rather than <any>
  @Output() delete: EventEmitter<BudgetItem> = new EventEmitter<BudgetItem>();
  //for purpose of updating total price:
  @Output() update: EventEmitter<UpdateEvent> = new EventEmitter<UpdateEvent>();
  
  // LocalStorage Module
  @NgModule({
    imports: [ StorageServiceModule ]
  })
  
  currentBudgetList = []
  // Data Storage Key:
  STORAGE_KEY = 'storedBudgetItems'

  // Inject local storage
  constructor(public dialog: MatDialog, @Inject (LOCAL_STORAGE) private storage: StorageService) {}
  
  public storeOnLocalStorage(description: string, amount: number): void{
    // get array of budget items from local storage
    this.currentBudgetList.push(this.storage.get(this.STORAGE_KEY) || []);

    // push new budget item to array
    this.currentBudgetList.push(this.budgetItems)

    // insert updated array to local storage
    this.storage.set(this.STORAGE_KEY, this.currentBudgetList)
    console.log('localStorage in main pg', this.storage.get(this.STORAGE_KEY))
  }
  

  ngOnInit(): void {}

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
