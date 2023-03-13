import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { productGrid } from './productGrid';

$(function() {
    initFullHeightGridPage(new productGrid($('#GridDiv')).element);
});