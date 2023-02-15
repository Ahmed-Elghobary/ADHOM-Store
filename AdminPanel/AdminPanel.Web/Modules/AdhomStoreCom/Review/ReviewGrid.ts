import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ReviewColumns, ReviewRow, ReviewService } from '../../ServerTypes/AdhomStoreCom';
import { ReviewDialog } from './ReviewDialog';

@Decorators.registerClass('AdminPanel.AdhomStoreCom.ReviewGrid')
export class ReviewGrid extends EntityGrid<ReviewRow, any> {
    protected getColumnsKey() { return ReviewColumns.columnsKey; }
    protected getDialogType() { return ReviewDialog; }
    protected getIdProperty() { return ReviewRow.idProperty; }
    protected getInsertPermission() { return ReviewRow.insertPermission; }
    protected getLocalTextPrefix() { return ReviewRow.localTextPrefix; }
    protected getService() { return ReviewService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}