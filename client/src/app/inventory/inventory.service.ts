import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
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

  getProducts()
  {
    return this.http.get<IPagination>(this.baseUrl + 'products?pageSize=20');
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
