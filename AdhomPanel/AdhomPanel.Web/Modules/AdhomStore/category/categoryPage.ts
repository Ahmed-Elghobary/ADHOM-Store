import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { categoryGrid } from './categoryGrid';

$(function() {
    initFullHeightGridPage(new categoryGrid($('#GridDiv')).element);
});