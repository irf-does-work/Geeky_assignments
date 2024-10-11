import { Routes } from '@angular/router';
import { AlertButtonComponent } from '../alert-button/alert-button.component';
import { FactsTableComponent } from '../facts-table/facts-table.component';
import { NestedListComponent } from '../nested-list/nested-list.component';
import { ColorfulListComponent } from '../colorful-list/colorful-list.component';
import { LeapYearComponent } from '../leap-year/leap-year.component';
import { ShoppingListComponent } from '../shopping-list/shopping-list.component';
import { GoogleLinksComponent } from '../google-links/google-links.component';

export const routes: Routes = [

    {path: 'alert-button', component: AlertButtonComponent},
    {path: 'colorful-list', component: ColorfulListComponent},
    {path: 'nested-list', component: NestedListComponent},
    {path: 'leap-year', component: LeapYearComponent},
    {path: 'google-links', component: GoogleLinksComponent},
    {path: 'facts-table', component: FactsTableComponent},
    {path: 'shopping-list', component: ShoppingListComponent},
    
];
