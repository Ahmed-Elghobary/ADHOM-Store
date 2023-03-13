import { fieldsProxy } from "@serenity-is/corelib/q";

export interface cartRow {
    Id?: number;
    UserId?: string;
    ProductId?: number;
    Qty?: number;
    ProductName?: string;
    ProductDescription?: string;
    ProductPrice?: number;
    ProductCatId?: number;
    ProductImage?: string;
    ProductType?: string;
    ProductSupllierName?: string;
    ProductEntryDate?: string;
    ProductReviewUrl?: string;
    ProductQty?: number;
}

export abstract class cartRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'UserId';
    static readonly localTextPrefix = 'AdhomStore.cart';
    static readonly deletePermission = 'cart';
    static readonly insertPermission = 'cart';
    static readonly readPermission = 'cart';
    static readonly updatePermission = 'cart';

    static readonly Fields = fieldsProxy<cartRow>();
}
