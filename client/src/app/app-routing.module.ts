import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DecantingComponent } from './decanting/decanting.component';
import { HomeComponent } from './home/home.component';
import { InventoryComponent } from './inventory/inventory.component';

const routes: Routes = [

    {path: 'inventory', component: InventoryComponent},
    {path: 'decanting', component: DecantingComponent},
  {path: 'home', component: HomeComponent},
  {path: '**', redirectTo: '/home', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
