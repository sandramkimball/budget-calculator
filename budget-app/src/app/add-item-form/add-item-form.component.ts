import { Component, Input, Output, OnInit, EventEmitter } from '@angular/core';
import { NgForm } from '@angular/forms';
import { BudgetItem } from 'src/shared/models/budget-item.model';

// for LocalStorage
import { NgModule } from '@angular/core';
import { StorageServiceModule } from 'ngx-webstorage-service';
import { Injectable, Inject } from '@angular/core';
import { LOCAL_STORAGE, StorageService } from 'ngx-webstorage-service';

@Component({
  selector: 'app-add-item-form',
  templateUrl: './add-item-form.component.html',
  styleUrls: ['./add-item-form.component.scss']
})

@Injectable()

export class AddItemFormComponent implements OnInit {

  // Takes in binded form inputs and creates new object from BudgetItem model.
  @Input() item: BudgetItem 
  // Submit new objects using EventEmitter (which is like =(e)=> )
  @Output() formSubmit: EventEmitter<BudgetItem> = new EventEmitter<BudgetItem>();

  // LocalStorage Module
  @NgModule({
    imports: [ StorageServiceModule ]
  })

  // Conditionally render 'Add' item button, or 'Save' updated item button.
  isNewItem: boolean;
  currentBudgetList = []
  
  // Data Storage Key:
  STORAGE_KEY = 'storedBudgetItems'
  
  // Inject local storage
  constructor(@Inject (LOCAL_STORAGE) private storage: StorageService) {}

  ngOnInit() {
    //check for item has value
    if (this.item){
      this.isNewItem = false
    } else {
      this.isNewItem = true;
      this.item = new BudgetItem('', null)
    }
  }

  // Define onSubmit function
  onSubmit(form: NgForm){
    this.formSubmit.emit(form.value)
    form.reset()

    // push new budget item to array
    this.currentBudgetList.push(form.value)

    // insert updated array to local storage
    this.storage.set(this.STORAGE_KEY, this.currentBudgetList)
    console.log('localStorage:', this.storage.get(this.STORAGE_KEY))
  }
}
