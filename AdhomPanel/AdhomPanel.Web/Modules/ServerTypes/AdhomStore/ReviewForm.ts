import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ReviewForm {
    Name: StringEditor;
    Email: StringEditor;
    Subject: StringEditor;
    Description: StringEditor;
}

export class ReviewForm extends PrefixedContext {
    static formKey = 'AdhomStore.Review';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ReviewForm.init)  {
            ReviewForm.init = true;

            var w0 = StringEditor;

            initFormType(ReviewForm, [
                'Name', w0,
                'Email', w0,
                'Subject', w0,
                'Description', w0
            ]);
        }
    }
}
