import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DecantingComponent } from './decanting/decanting.component';
import { LoginComponent } from './login/login.component';
import { DashboardComponent } from './dashboard/dashboard.component';

const routes: Routes = [

  { path: 'inventory', loadChildren: () => import('./inventory/inventory.module').then(mod => mod.InventoryModule), data: {breadcrumb: 'Inventory'}},
  { path: 'decanting', component: DecantingComponent, data: {breadcrumb: 'Decanting'} },
  { path: 'login', component: LoginComponent },
  
  { path: '', component: DashboardComponent, data: {breadcrumb: 'Home'}}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
