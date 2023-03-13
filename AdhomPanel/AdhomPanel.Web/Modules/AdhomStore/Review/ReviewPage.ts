import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ReviewGrid } from './ReviewGrid';

$(function() {
    initFullHeightGridPage(new ReviewGrid($('#GridDiv')).element);
});