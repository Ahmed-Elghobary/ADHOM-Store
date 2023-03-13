import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ProductImageRow {
    Id?: number;
    ProductId?: number;
    Image?: string;
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

export abstract class ProductImageRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Image';
    static readonly localTextPrefix = 'AdhomStore.ProductImage';
    static readonly deletePermission = 'ProductImage';
    static readonly insertPermission = 'ProductImage';
    static readonly readPermission = 'ProductImage';
    static readonly updatePermission = 'ProductImage';

    static readonly Fields = fieldsProxy<ProductImageRow>();
}
