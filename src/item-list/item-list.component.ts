import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Input } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-item-list',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './item-list.component.html',
  styleUrl: './item-list.component.scss'
})
export class ItemListComponent {
  //items : string[] =[];
  @Input() items: string[] = [];
  // addItem(newItem: string) {
  //   this.items.push(newItem);
  // }
  deleteItem(index: number) {
    this.items.splice(index, 1); 
  }
}
