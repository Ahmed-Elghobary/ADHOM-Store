import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CartColumns, CartRow, CartService } from '../../ServerTypes/AdhomStoreCom';
import { CartDialog } from './CartDialog';

@Decorators.registerClass('AdminPanel.AdhomStoreCom.CartGrid')
export class CartGrid extends EntityGrid<CartRow, any> {
    protected getColumnsKey() { return CartColumns.columnsKey; }
    protected getDialogType() { return CartDialog; }
    protected getIdProperty() { return CartRow.idProperty; }
    protected getInsertPermission() { return CartRow.insertPermission; }
    protected getLocalTextPrefix() { return CartRow.localTextPrefix; }
    protected getService() { return CartService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}