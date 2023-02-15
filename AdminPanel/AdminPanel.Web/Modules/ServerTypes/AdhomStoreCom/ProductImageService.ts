import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { ProductImageRow } from "./ProductImageRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace ProductImageService {
    export const baseUrl = 'AdhomStoreCom/ProductImage';

    export declare function Create(request: SaveRequest<ProductImageRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<ProductImageRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProductImageRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProductImageRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "AdhomStoreCom/ProductImage/Create",
        Update: "AdhomStoreCom/ProductImage/Update",
        Delete: "AdhomStoreCom/ProductImage/Delete",
        Retrieve: "AdhomStoreCom/ProductImage/Retrieve",
        List: "AdhomStoreCom/ProductImage/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ProductImageService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
