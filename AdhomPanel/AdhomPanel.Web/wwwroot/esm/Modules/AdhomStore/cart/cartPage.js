import{a as u,b as p,c as e,d as n}from"../../../_chunks/chunk-ZUMIWV5P.js";import{a as o,b as c,c as i,e as g,f as a}from"../../../_chunks/chunk-K3EI6ARL.js";var l=c(g(),1);var m=c(a(),1);var s=c(a(),1);var r=class extends s.EntityDialog{constructor(){super(...arguments);this.form=new p(this.idPrefix)}getFormKey(){return p.formKey}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return n.baseUrl}getDeletePermission(){return e.deletePermission}getInsertPermission(){return e.insertPermission}getUpdatePermission(){return e.updatePermission}};o(r,"cartDialog"),r=i([s.Decorators.registerClass("AdhomPanel.AdhomStore.cartDialog")],r);var t=class extends m.EntityGrid{getColumnsKey(){return u.columnsKey}getDialogType(){return r}getIdProperty(){return e.idProperty}getInsertPermission(){return e.insertPermission}getLocalTextPrefix(){return e.localTextPrefix}getService(){return n.baseUrl}constructor(d){super(d)}};o(t,"cartGrid"),t=i([m.Decorators.registerClass("AdhomPanel.AdhomStore.cartGrid")],t);$(function(){(0,l.initFullHeightGridPage)(new t($("#GridDiv")).element)});
//# sourceMappingURL=cartPage.js.map
