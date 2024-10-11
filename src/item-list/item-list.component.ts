import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { TransferItemService } from '../transfer-item.service';
import { OnInit } from '@angular/core';
import { concatWith } from 'rxjs';

@Component({
  selector: 'app-item-list',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './item-list.component.html',
  styleUrl: './item-list.component.scss'
})
export class ItemListComponent {
  
  itemsList: string[] = [];
  constructor(private transferItemService : TransferItemService){

  }

  ngOnInit(){
    this.transferItemService.itemObservable.subscribe((item)=> {this.itemsList.push(item)});
    //console.log("Item-list initialized")
  }

  
  deleteItem(index: number) {
    this.itemsList.splice(index, 1); 
  }
}
