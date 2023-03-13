import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { cartForm, cartRow, cartService } from '../../ServerTypes/AdhomStore';

@Decorators.registerClass('AdhomPanel.AdhomStore.cartDialog')
export class cartDialog extends EntityDialog<cartRow, any> {
    protected getFormKey() { return cartForm.formKey; }
    protected getIdProperty() { return cartRow.idProperty; }
    protected getLocalTextPrefix() { return cartRow.localTextPrefix; }
    protected getNameProperty() { return cartRow.nameProperty; }
    protected getService() { return cartService.baseUrl; }
    protected getDeletePermission() { return cartRow.deletePermission; }
    protected getInsertPermission() { return cartRow.insertPermission; }
    protected getUpdatePermission() { return cartRow.updatePermission; }

    protected form = new cartForm(this.idPrefix);
}