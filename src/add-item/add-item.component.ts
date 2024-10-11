import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { TransferItemService } from '../transfer-item.service';

@Component({
  selector: 'app-add-item',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-item.component.html',
  styleUrl: './add-item.component.scss'
})
export class AddItemComponent {

  item : string ='';  
  
  constructor(private transferItemService : TransferItemService){

  }
  
  addNewItem() {
    //console.log("CLICKED ADD ITEM BUTTON and item is: " +this.item);
    this.transferItemService.addItem(this.item); 
  } 

} 
