import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CartForm, CartRow, CartService } from '../../ServerTypes/AdhomStoreCom';

@Decorators.registerClass('AdminPanel.AdhomStoreCom.CartDialog')
export class CartDialog extends EntityDialog<CartRow, any> {
    protected getFormKey() { return CartForm.formKey; }
    protected getIdProperty() { return CartRow.idProperty; }
    protected getLocalTextPrefix() { return CartRow.localTextPrefix; }
    protected getNameProperty() { return CartRow.nameProperty; }
    protected getService() { return CartService.baseUrl; }
    protected getDeletePermission() { return CartRow.deletePermission; }
    protected getInsertPermission() { return CartRow.insertPermission; }
    protected getUpdatePermission() { return CartRow.updatePermission; }

    protected form = new CartForm(this.idPrefix);
}