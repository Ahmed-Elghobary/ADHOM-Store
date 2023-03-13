import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { productForm, productRow, productService } from '../../ServerTypes/AdhomStore';

@Decorators.registerClass('AdhomPanel.AdhomStore.productDialog')
export class productDialog extends EntityDialog<productRow, any> {
    protected getFormKey() { return productForm.formKey; }
    protected getIdProperty() { return productRow.idProperty; }
    protected getLocalTextPrefix() { return productRow.localTextPrefix; }
    protected getNameProperty() { return productRow.nameProperty; }
    protected getService() { return productService.baseUrl; }
    protected getDeletePermission() { return productRow.deletePermission; }
    protected getInsertPermission() { return productRow.insertPermission; }
    protected getUpdatePermission() { return productRow.updatePermission; }

    protected form = new productForm(this.idPrefix);
}