import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { cartColumns, cartRow, cartService } from '../../ServerTypes/AdhomStore';
import { cartDialog } from './cartDialog';

@Decorators.registerClass('AdhomPanel.AdhomStore.cartGrid')
export class cartGrid extends EntityGrid<cartRow, any> {
    protected getColumnsKey() { return cartColumns.columnsKey; }
    protected getDialogType() { return cartDialog; }
    protected getIdProperty() { return cartRow.idProperty; }
    protected getInsertPermission() { return cartRow.insertPermission; }
    protected getLocalTextPrefix() { return cartRow.localTextPrefix; }
    protected getService() { return cartService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}