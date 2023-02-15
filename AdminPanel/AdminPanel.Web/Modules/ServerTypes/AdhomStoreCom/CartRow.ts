import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CartRow {
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

export abstract class CartRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'UserId';
    static readonly localTextPrefix = 'AdhomStoreCom.Cart';
    static readonly deletePermission = 'Cart';
    static readonly insertPermission = 'Cart';
    static readonly readPermission = 'Cart';
    static readonly updatePermission = 'Cart';

    static readonly Fields = fieldsProxy<CartRow>();
}
