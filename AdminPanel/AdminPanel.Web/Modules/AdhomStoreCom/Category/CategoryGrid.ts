import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CategoryColumns, CategoryRow, CategoryService } from '../../ServerTypes/AdhomStoreCom';
import { CategoryDialog } from './CategoryDialog';

@Decorators.registerClass('AdminPanel.AdhomStoreCom.CategoryGrid')
export class CategoryGrid extends EntityGrid<CategoryRow, any> {
    protected getColumnsKey() { return CategoryColumns.columnsKey; }
    protected getDialogType() { return CategoryDialog; }
    protected getIdProperty() { return CategoryRow.idProperty; }
    protected getInsertPermission() { return CategoryRow.insertPermission; }
    protected getLocalTextPrefix() { return CategoryRow.localTextPrefix; }
    protected getService() { return CategoryService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}