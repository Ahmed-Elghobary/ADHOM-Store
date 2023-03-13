import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { productColumns, productRow, productService } from '../../ServerTypes/AdhomStore';
import { productDialog } from './productDialog';

@Decorators.registerClass('AdhomPanel.AdhomStore.productGrid')
export class productGrid extends EntityGrid<productRow, any> {
    protected getColumnsKey() { return productColumns.columnsKey; }
    protected getDialogType() { return productDialog; }
    protected getIdProperty() { return productRow.idProperty; }
    protected getInsertPermission() { return productRow.insertPermission; }
    protected getLocalTextPrefix() { return productRow.localTextPrefix; }
    protected getService() { return productService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}