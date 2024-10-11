import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AddItemComponent } from '../add-item/add-item.component';
import { ItemListComponent } from '../item-list/item-list.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,AddItemComponent,ItemListComponent,FormsModule,CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'shopping-list';
   items : string[] = [];

   onItemAdded(newItem: string) {
    console.log('New item added:', newItem);
    this.items.push(newItem);
    
   }
}
