import { LookupEditor, ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProductImageForm {
    ProductId: LookupEditor;
    Image: ImageUploadEditor;
}

export class ProductImageForm extends PrefixedContext {
    static formKey = 'AdhomStore.ProductImage';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductImageForm.init)  {
            ProductImageForm.init = true;

            var w0 = LookupEditor;
            var w1 = ImageUploadEditor;

            initFormType(ProductImageForm, [
                'ProductId', w0,
                'Image', w1
            ]);
        }
    }
}
