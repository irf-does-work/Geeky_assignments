import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormComponent } from '../form/form.component';
import { ReactiveFormsModule } from '@angular/forms';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,FormComponent,ReactiveFormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'reactive-forms-app';
}
