import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ReviewForm, ReviewRow, ReviewService } from '../../ServerTypes/AdhomStoreCom';

@Decorators.registerClass('AdminPanel.AdhomStoreCom.ReviewDialog')
export class ReviewDialog extends EntityDialog<ReviewRow, any> {
    protected getFormKey() { return ReviewForm.formKey; }
    protected getIdProperty() { return ReviewRow.idProperty; }
    protected getLocalTextPrefix() { return ReviewRow.localTextPrefix; }
    protected getNameProperty() { return ReviewRow.nameProperty; }
    protected getService() { return ReviewService.baseUrl; }
    protected getDeletePermission() { return ReviewRow.deletePermission; }
    protected getInsertPermission() { return ReviewRow.insertPermission; }
    protected getUpdatePermission() { return ReviewRow.updatePermission; }

    protected form = new ReviewForm(this.idPrefix);
}