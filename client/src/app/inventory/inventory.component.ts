import { Component } from '@angular/core';
import { IGrade } from '../shared/models/grade';
import { ILotNumber } from '../shared/models/lotnumber';
import { IPackaging } from '../shared/models/packaging';
import { IProduct } from '../shared/models/product';
import { IStatus } from '../shared/models/status';
import { IWarehouse } from '../shared/models/warehouse';
import { InventoryService } from './inventory.service';

@Component({
  selector: 'app-inventory',
  templateUrl: './inventory.component.html',
  styleUrls: ['./inventory.component.scss']
})
export class InventoryComponent {
  products: IProduct[];
  grades: IGrade[];
  lotnumbers: ILotNumber[];
  packaging: IPackaging[];
  statuses: IStatus[];
  warehouses: IWarehouse[];
  

  constructor(private inventoryService: InventoryService) {}

  ngOnInit() 
  {
    this.getProducts();
    this.getGrades();
    this.getLotNumbers();
    this.getPackaging();
    this.getStatuses();
    this.getWarehouses();
  }

  getProducts()
  {
    this.inventoryService.getProducts().subscribe(response => {
      this.products = response.data;
    }, error => {
      console.log(error);
    }); 
  }

  getGrades()
  {
    this.inventoryService.getGrades().subscribe(response => {
      this.grades = response;
    }, error => {
      console.log(error);
    });
  }

  getLotNumbers()
  {
    this.inventoryService.getLotNumbers().subscribe(response => {
      this.lotnumbers = response;
    }, error => {
      console.log(error);
    });
  }

  getPackaging()
  {
    this.inventoryService.getPackaging().subscribe(response => {
      this.packaging = response;
    }, error => {
      console.log(error);
    });
  }

  getStatuses()
  {
    this.inventoryService.getStatuses().subscribe(response => {
      this.statuses = response;
    }, error => {
      console.log(error);
    });
  }

  getWarehouses()
  {
    this.inventoryService.getWarehouses().subscribe(response => {
      this.warehouses = response;
    }, error => {
      console.log(error);
    });
  }

}
