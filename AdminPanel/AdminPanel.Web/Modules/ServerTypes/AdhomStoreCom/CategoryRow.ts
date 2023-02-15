import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoryRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Image?: string;
}

export abstract class CategoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AdhomStoreCom.Category';
    static readonly lookupKey = 'AdhomStoreCom.Category';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CategoryRow>('AdhomStoreCom.Category') }
    static async getLookupAsync() { return getLookupAsync<CategoryRow>('AdhomStoreCom.Category') }

    static readonly deletePermission = 'Category';
    static readonly insertPermission = 'Category';
    static readonly readPermission = 'Category';
    static readonly updatePermission = 'Category';

    static readonly Fields = fieldsProxy<CategoryRow>();
}
