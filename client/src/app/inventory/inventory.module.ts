import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InventoryComponent } from './inventory.component';
import { ProductItemComponent } from './product-item/product-item.component';
import { SharedModule } from '../shared/shared.module';
import { InventoryRoutingModule } from './inventory-routing.module';



@NgModule({
  declarations: [
    InventoryComponent,
    ProductItemComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    InventoryRoutingModule
  ]
})
export class InventoryModule { }
 