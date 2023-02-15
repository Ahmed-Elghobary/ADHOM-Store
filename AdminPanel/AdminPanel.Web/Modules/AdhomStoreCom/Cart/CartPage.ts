import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CartGrid } from './CartGrid';

$(function() {
    initFullHeightGridPage(new CartGrid($('#GridDiv')).element);
});