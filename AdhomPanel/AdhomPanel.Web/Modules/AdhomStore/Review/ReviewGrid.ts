import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ReviewColumns, ReviewRow, ReviewService } from '../../ServerTypes/AdhomStore';
import { ReviewDialog } from './ReviewDialog';

@Decorators.registerClass('AdhomPanel.AdhomStore.ReviewGrid')
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