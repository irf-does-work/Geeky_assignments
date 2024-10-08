import { Component } from '@angular/core';

@Component({
  selector: 'app-leap-year',
  standalone: true,
  imports: [],
  templateUrl: './leap-year.component.html',
  styleUrl: './leap-year.component.scss'
})
export class LeapYearComponent {
  isLeapYear(): void {
    let yearInputBox = document.getElementById('inputYearBox') as HTMLInputElement;
    let enteredYear = parseFloat(yearInputBox.value);
    let resultText = document.getElementById('result');
    
    
    if (enteredYear % 400 == 0 || (enteredYear % 4 == 0 && enteredYear % 100 !=0)) {
      resultText!.innerText = enteredYear + ' is a leap year';
    }

    else {
      resultText!.innerText = enteredYear + ' is NOT a leap year';
    }

  }
}


