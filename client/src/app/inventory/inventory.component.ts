import { Component } from '@angular/core';
import { IProduct } from '../shared/models/product';
import { InventoryService } from './inventory.service';

@Component({
  selector: 'app-inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.scss']
})
export class InventoryComponent {
  products: IProduct[];

  constructor(private inventoryService: InventoryService) {}

  ngOnInit() 
  {
    this.inventoryService.getProducts().subscribe(response => {
      this.products = response.data;
    }, error => {
      console.log(error);
    })  
  }

}
