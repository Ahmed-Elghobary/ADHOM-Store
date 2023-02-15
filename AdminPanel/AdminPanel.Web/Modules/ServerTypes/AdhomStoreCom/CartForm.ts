import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CartForm {
    UserId: StringEditor;
    ProductId: IntegerEditor;
    Qty: IntegerEditor;
}

export class CartForm extends PrefixedContext {
    static formKey = 'AdhomStoreCom.Cart';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CartForm.init)  {
            CartForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(CartForm, [
                'UserId', w0,
                'ProductId', w1,
                'Qty', w1
            ]);
        }
    }
}
