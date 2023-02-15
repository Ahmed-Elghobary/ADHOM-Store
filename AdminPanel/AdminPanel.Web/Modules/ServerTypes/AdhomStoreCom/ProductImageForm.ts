import { IntegerEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProductImageForm {
    ProductId: IntegerEditor;
    Image: StringEditor;
}

export class ProductImageForm extends PrefixedContext {
    static formKey = 'AdhomStoreCom.ProductImage';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductImageForm.init)  {
            ProductImageForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(ProductImageForm, [
                'ProductId', w0,
                'Image', w1
            ]);
        }
    }
}
