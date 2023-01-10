import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InventoryComponent } from './inventory.component';
import { ProductItemComponent } from './product-item/product-item.component';



@NgModule({
  declarations: [
    InventoryComponent,
    ProductItemComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [InventoryComponent]
})
export class InventoryModule { }
