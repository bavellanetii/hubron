import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs';
import { InventoryParams } from '../shared/inventoryParams';
import { IGrade } from '../shared/models/grade';
import { ILotNumber } from '../shared/models/lotnumber';
import { IPackaging } from '../shared/models/packaging';
import { IPagination } from '../shared/models/pagination';
import { IStatus } from '../shared/models/status';
import { IWarehouse } from '../shared/models/warehouse';

@Injectable({
  providedIn: 'root'
})
export class InventoryService {
  baseUrl = 'https://localhost:7279/api/';

  constructor(private http: HttpClient) { }

  getProducts(inventoryParams: InventoryParams)
  {
    let params = new HttpParams();

    if (inventoryParams.packagingId !== 0) 
    {
      params = params.append('packagingId', inventoryParams.packagingId.toString());
    }

    if (inventoryParams.statusId !== 0) 
    {
      params = params.append('statusId', inventoryParams.statusId.toString());
    }

    if (inventoryParams.warehouseId !== 0) 
    {
      params = params.append('warehouseId', inventoryParams.warehouseId.toString());
    }

      params = params.append('sort', inventoryParams.sort);
      params = params.append('pageIndex', inventoryParams.pageNumber.toString());
      params = params.append('pageIndex', inventoryParams.pageSize.toString());

    return this.http.get<IPagination>(this.baseUrl + 'products', {observe: 'response', params})
      .pipe(
        map(response => {
          return response.body;
        })
      );
  }

  getGrades()
  {
    return this.http.get<IGrade[]>(this.baseUrl + 'products/grades')
  }

  getLotNumbers()
  {
    return this.http.get<ILotNumber[]>(this.baseUrl + 'products/lotnumbers')
  }

  getPackaging()
  {
    return this.http.get<IPackaging[]>(this.baseUrl + 'products/packaging')
  }

  getStatuses()
  {
    return this.http.get<IStatus[]>(this.baseUrl + 'products/statuses')
  }

  getWarehouses()
  {
    return this.http.get<IWarehouse[]>(this.baseUrl + 'products/warehouses')
  }

}
