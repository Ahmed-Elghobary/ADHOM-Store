import { StringEditor, DecimalEditor, LookupEditor, ImageUploadEditor, DateEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface productForm {
    Name: StringEditor;
    Description: StringEditor;
    Price: DecimalEditor;
    CatId: LookupEditor;
    Image: ImageUploadEditor;
    Type: StringEditor;
    SupllierName: StringEditor;
    EntryDate: DateEditor;
    ReviewUrl: StringEditor;
    Qty: IntegerEditor;
}

export class productForm extends PrefixedContext {
    static formKey = 'AdhomStore.product';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!productForm.init)  {
            productForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = LookupEditor;
            var w3 = ImageUploadEditor;
            var w4 = DateEditor;
            var w5 = IntegerEditor;

            initFormType(productForm, [
                'Name', w0,
                'Description', w0,
                'Price', w1,
                'CatId', w2,
                'Image', w3,
                'Type', w0,
                'SupllierName', w0,
                'EntryDate', w4,
                'ReviewUrl', w0,
                'Qty', w5
            ]);
        }
    }
}
