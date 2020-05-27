import { Component, Input, Output, OnInit, EventEmitter } from '@angular/core';
import { NgForm } from '@angular/forms';
import { BudgetItem } from 'src/shared/models/budget-item.model';

@Component({
  selector: 'app-add-item-form',
  templateUrl: './add-item-form.component.html',
  styleUrls: ['./add-item-form.component.scss']
})
export class AddItemFormComponent implements OnInit {

  // Takes in binded form inputs and creates new object from BudgetItem model.
  @Input() item: BudgetItem 
  // Submit new objects using EventEmitter (which is like =(e)=> )
  @Output() formSubmit: EventEmitter<BudgetItem> = new EventEmitter<BudgetItem>();

  //conditionally render Add item, or Save update item button.
  isNewItem: boolean;

  constructor() { }

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
  }
}
