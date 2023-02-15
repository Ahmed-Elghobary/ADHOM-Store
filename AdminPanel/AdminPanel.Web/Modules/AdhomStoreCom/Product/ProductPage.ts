import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ProductGrid } from './ProductGrid';

$(function() {
    initFullHeightGridPage(new ProductGrid($('#GridDiv')).element);
});