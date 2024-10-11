import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { AlertButtonComponent } from '../alert-button/alert-button.component';
import { FactsTableComponent } from '../facts-table/facts-table.component';
import { ColorfulListComponent } from '../colorful-list/colorful-list.component';
import { NestedListComponent } from '../nested-list/nested-list.component';
import { GoogleLinksComponent } from '../google-links/google-links.component';
import { LeapYearComponent } from '../leap-year/leap-year.component';
import { ShoppingListComponent } from '../shopping-list/shopping-list.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    CommonModule,
    RouterLink,
    RouterLinkActive,
    AlertButtonComponent,
    FactsTableComponent,
    ColorfulListComponent,
    NestedListComponent,
    GoogleLinksComponent,
    LeapYearComponent,
    ShoppingListComponent
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'my-first-app';
}
