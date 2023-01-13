import { Component, ElementRef, ViewChild } from '@angular/core';
import { InventoryParams } from '../shared/inventoryParams';
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
  @ViewChild('search', {static: true}) searchTerm: ElementRef;
  products: IProduct[];
  grades: IGrade[];
  lotnumbers: ILotNumber[];
  packaging: IPackaging[];
  statuses: IStatus[];
  warehouses: IWarehouse[];
  inventoryParams = new InventoryParams();
  totalCount : number;
  sortOptions = [
    {name: 'Grade', value: 'default'},
    {name: 'Warehouse', value: 'warehouse'},
    {name: 'Lot Number', value: 'lotNumberAscending'}
  ];
  

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
    this.inventoryService.getProducts(this.inventoryParams)
    .subscribe(response => {
      this.products = response.data;
      this.inventoryParams.pageNumber = response.pageIndex;
      this.inventoryParams.pageSize = response.pageSize;
      this.totalCount = response.count;
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
      this.packaging = [{id: 0, name: 'All'}, ...response];
    }, error => {
      console.log(error);
    });
  }

  getStatuses()
  {
    this.inventoryService.getStatuses().subscribe(response => {
      this.statuses = [{id: 0, name: 'All'}, ...response];
    }, error => {
      console.log(error);
    });
  }

  getWarehouses()
  {
    this.inventoryService.getWarehouses().subscribe(response => {
      this.warehouses = [{id: 0, name: 'All'}, ...response];
    }, error => {
      console.log(error);
    });
  }

  onWarehouseSelected(warehouseId: number)
  {
    this.inventoryParams.warehouseId = warehouseId;
    this.inventoryParams.pageNumber = 1;
    this.getProducts();
  }

  onPackagingSelected(packagingId: number)
  {
    this.inventoryParams.packagingId = packagingId;
    this.inventoryParams.pageNumber = 1;
    this.getProducts();
  }

  onStatusSelected(statusId: number)
  {
    this.inventoryParams.statusId = statusId;
    this.inventoryParams.pageNumber = 1;
    this.getProducts();
  }

  onSortSelected(sort: string)
  {
    this.inventoryParams.sort = sort;
    this.inventoryParams.pageNumber = 1;
    this.getProducts();
  }

  onPageChanged(event: any)
  {
    if(this.inventoryParams.pageNumber !== event)
    {
      this.inventoryParams.pageNumber = event;
      this.getProducts();
    }
  }

  onSearch() 
  {
    this.inventoryParams.search = this.searchTerm.nativeElement.value;
    this.inventoryParams.pageNumber = 1;
    this.getProducts();
  }

  onReset()
  {
    this.searchTerm.nativeElement.value = undefined;
    this.inventoryParams = new InventoryParams();
    this.getProducts();
  }

}
