import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ProductRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Price?: number;
    CatId?: number;
    Image?: string;
    Type?: string;
    SupllierName?: string;
    EntryDate?: string;
    ReviewUrl?: string;
    Qty?: number;
    CatName?: string;
    CatDescription?: string;
    CatImage?: string;
}

export abstract class ProductRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AdhomStoreCom.Product';
    static readonly deletePermission = 'Product';
    static readonly insertPermission = 'Product';
    static readonly readPermission = 'Product';
    static readonly updatePermission = 'Product';

    static readonly Fields = fieldsProxy<ProductRow>();
}
