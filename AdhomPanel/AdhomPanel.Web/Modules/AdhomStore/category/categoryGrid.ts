import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { categoryColumns, categoryRow, categoryService } from '../../ServerTypes/AdhomStore';
import { categoryDialog } from './categoryDialog';

@Decorators.registerClass('AdhomPanel.AdhomStore.categoryGrid')
export class categoryGrid extends EntityGrid<categoryRow, any> {
    protected getColumnsKey() { return categoryColumns.columnsKey; }
    protected getDialogType() { return categoryDialog; }
    protected getIdProperty() { return categoryRow.idProperty; }
    protected getInsertPermission() { return categoryRow.insertPermission; }
    protected getLocalTextPrefix() { return categoryRow.localTextPrefix; }
    protected getService() { return categoryService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}