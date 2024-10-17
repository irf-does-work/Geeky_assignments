import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-shopping-list',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './shopping-list.component.html',
  styleUrl: './shopping-list.component.scss'
})
export class ShoppingListComponent {
  item : string ='';
  itemList : string[] =[];

  newItem(): void {
    this.itemList.push(this.item);
  }

  deleteItem(index: number){
    this.itemList.splice(index,1);
  }
}
