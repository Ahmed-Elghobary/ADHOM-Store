import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProductImageColumns, ProductImageRow, ProductImageService } from '../../ServerTypes/AdhomStore';
import { ProductImageDialog } from './ProductImageDialog';

@Decorators.registerClass('AdhomPanel.AdhomStore.ProductImageGrid')
export class ProductImageGrid extends EntityGrid<ProductImageRow, any> {
    protected getColumnsKey() { return ProductImageColumns.columnsKey; }
    protected getDialogType() { return ProductImageDialog; }
    protected getIdProperty() { return ProductImageRow.idProperty; }
    protected getInsertPermission() { return ProductImageRow.insertPermission; }
    protected getLocalTextPrefix() { return ProductImageRow.localTextPrefix; }
    protected getService() { return ProductImageService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}