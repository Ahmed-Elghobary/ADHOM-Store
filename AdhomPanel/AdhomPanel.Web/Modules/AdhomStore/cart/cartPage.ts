import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { cartGrid } from './cartGrid';

$(function() {
    initFullHeightGridPage(new cartGrid($('#GridDiv')).element);
});