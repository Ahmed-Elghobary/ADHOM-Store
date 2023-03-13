import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface categoryRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Image?: string;
}

export abstract class categoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'AdhomStore.category';
    static readonly lookupKey = 'AdhomStore.category';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<categoryRow>('AdhomStore.category') }
    static async getLookupAsync() { return getLookupAsync<categoryRow>('AdhomStore.category') }

    static readonly deletePermission = 'category';
    static readonly insertPermission = 'category';
    static readonly readPermission = 'category';
    static readonly updatePermission = 'category';

    static readonly Fields = fieldsProxy<categoryRow>();
}
