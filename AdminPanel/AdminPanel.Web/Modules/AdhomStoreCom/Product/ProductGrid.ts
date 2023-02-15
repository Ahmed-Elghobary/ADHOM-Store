import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProductColumns, ProductRow, ProductService } from '../../ServerTypes/AdhomStoreCom';
import { ProductDialog } from './ProductDialog';

@Decorators.registerClass('AdminPanel.AdhomStoreCom.ProductGrid')
export class ProductGrid extends EntityGrid<ProductRow, any> {
    protected getColumnsKey() { return ProductColumns.columnsKey; }
    protected getDialogType() { return ProductDialog; }
    protected getIdProperty() { return ProductRow.idProperty; }
    protected getInsertPermission() { return ProductRow.insertPermission; }
    protected getLocalTextPrefix() { return ProductRow.localTextPrefix; }
    protected getService() { return ProductService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}