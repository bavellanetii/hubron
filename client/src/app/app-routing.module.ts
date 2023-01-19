import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DecantingComponent } from './decanting/decanting.component';
import { LoginComponent } from './login/login.component';
import { InventoryComponent } from './inventory/inventory.component';

const routes: Routes = [

    {path: 'inventory', component: InventoryComponent},
    {path: 'decanting', component: DecantingComponent},
  {path: 'login', component: LoginComponent},
  {path: '**', redirectTo: '/login', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
