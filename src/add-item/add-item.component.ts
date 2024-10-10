import { Component } from '@angular/core';
import { EventEmitter,Output,Input } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-item',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-item.component.html',
  styleUrl: './add-item.component.scss'
})
export class AddItemComponent {

  item : string ='';  
  @Output() newItemEvent = new EventEmitter<string>();
  
  
  addNewItem() {
    this.newItemEvent.emit(this.item);
  } 

} 
