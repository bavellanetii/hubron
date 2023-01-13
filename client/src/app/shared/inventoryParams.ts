export class InventoryParams {
    packagingId: number = 0;
    statusId: number = 0;
    warehouseId: number = 0;
    sort = 'default';
    pageNumber = 1;
    pageSize = 30;
    search: string;
}