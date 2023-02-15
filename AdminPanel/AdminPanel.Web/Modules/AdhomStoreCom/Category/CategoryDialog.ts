import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoryForm, CategoryRow, CategoryService } from '../../ServerTypes/AdhomStoreCom';

@Decorators.registerClass('AdminPanel.AdhomStoreCom.CategoryDialog')
export class CategoryDialog extends EntityDialog<CategoryRow, any> {
    protected getFormKey() { return CategoryForm.formKey; }
    protected getIdProperty() { return CategoryRow.idProperty; }
    protected getLocalTextPrefix() { return CategoryRow.localTextPrefix; }
    protected getNameProperty() { return CategoryRow.nameProperty; }
    protected getService() { return CategoryService.baseUrl; }
    protected getDeletePermission() { return CategoryRow.deletePermission; }
    protected getInsertPermission() { return CategoryRow.insertPermission; }
    protected getUpdatePermission() { return CategoryRow.updatePermission; }

    protected form = new CategoryForm(this.idPrefix);
}