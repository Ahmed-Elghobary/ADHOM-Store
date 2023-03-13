import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface cartForm {
    UserId: StringEditor;
    ProductId: IntegerEditor;
    Qty: IntegerEditor;
}

export class cartForm extends PrefixedContext {
    static formKey = 'AdhomStore.cart';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!cartForm.init)  {
            cartForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(cartForm, [
                'UserId', w0,
                'ProductId', w1,
                'Qty', w1
            ]);
        }
    }
}
