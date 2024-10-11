import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TransferItemService {

  constructor() { }
  private subject1 = new Subject<string>();

  itemObservable = this.subject1.asObservable();

  addItem(item: string){
    //console.log("Got item Inside service: emitted:" + item);
    this.subject1.next(item);
    
  }
}
