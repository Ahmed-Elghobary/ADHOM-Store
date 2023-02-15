import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProductForm, ProductRow, ProductService } from '../../ServerTypes/AdhomStoreCom';

@Decorators.registerClass('AdminPanel.AdhomStoreCom.ProductDialog')
export class ProductDialog extends EntityDialog<ProductRow, any> {
    protected getFormKey() { return ProductForm.formKey; }
    protected getIdProperty() { return ProductRow.idProperty; }
    protected getLocalTextPrefix() { return ProductRow.localTextPrefix; }
    protected getNameProperty() { return ProductRow.nameProperty; }
    protected getService() { return ProductService.baseUrl; }
    protected getDeletePermission() { return ProductRow.deletePermission; }
    protected getInsertPermission() { return ProductRow.insertPermission; }
    protected getUpdatePermission() { return ProductRow.updatePermission; }

    protected form = new ProductForm(this.idPrefix);
}