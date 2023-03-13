import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface productRow {
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

export abstract class productRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AdhomStore.product';
    static readonly lookupKey = 'AdhomStore.product';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<productRow>('AdhomStore.product') }
    static async getLookupAsync() { return getLookupAsync<productRow>('AdhomStore.product') }

    static readonly deletePermission = 'product';
    static readonly insertPermission = 'product';
    static readonly readPermission = 'product';
    static readonly updatePermission = 'product';

    static readonly Fields = fieldsProxy<productRow>();
}
