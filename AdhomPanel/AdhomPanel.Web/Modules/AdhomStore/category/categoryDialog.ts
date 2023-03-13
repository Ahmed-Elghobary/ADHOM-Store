import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { categoryForm, categoryRow, categoryService } from '../../ServerTypes/AdhomStore';

@Decorators.registerClass('AdhomPanel.AdhomStore.categoryDialog')
export class categoryDialog extends EntityDialog<categoryRow, any> {
    protected getFormKey() { return categoryForm.formKey; }
    protected getIdProperty() { return categoryRow.idProperty; }
    protected getLocalTextPrefix() { return categoryRow.localTextPrefix; }
    protected getNameProperty() { return categoryRow.nameProperty; }
    protected getService() { return categoryService.baseUrl; }
    protected getDeletePermission() { return categoryRow.deletePermission; }
    protected getInsertPermission() { return categoryRow.insertPermission; }
    protected getUpdatePermission() { return categoryRow.updatePermission; }

    protected form = new categoryForm(this.idPrefix);
}