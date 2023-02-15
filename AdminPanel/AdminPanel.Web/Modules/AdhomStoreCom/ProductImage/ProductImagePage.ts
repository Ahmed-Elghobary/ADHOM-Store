import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ProductImageGrid } from './ProductImageGrid';

$(function() {
    initFullHeightGridPage(new ProductImageGrid($('#GridDiv')).element);
});