import{i as P,j as d,o as e,p as n}from"../../../_chunks/chunk-5HM53XBB.js";import{a as o,b as c,c as i,e as g,f as u}from"../../../_chunks/chunk-K3EI6ARL.js";var l=c(g(),1);var m=c(u(),1);var s=c(u(),1);var r=class extends s.EntityDialog{constructor(){super(...arguments);this.form=new d(this.idPrefix)}getFormKey(){return d.formKey}getIdProperty(){return e.idProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return n.baseUrl}getDeletePermission(){return e.deletePermission}getInsertPermission(){return e.insertPermission}getUpdatePermission(){return e.updatePermission}};o(r,"ProductDialog"),r=i([s.Decorators.registerClass("AdminPanel.AdhomStoreCom.ProductDialog")],r);var t=class extends m.EntityGrid{getColumnsKey(){return P.columnsKey}getDialogType(){return r}getIdProperty(){return e.idProperty}getInsertPermission(){return e.insertPermission}getLocalTextPrefix(){return e.localTextPrefix}getService(){return n.baseUrl}constructor(p){super(p)}};o(t,"ProductGrid"),t=i([m.Decorators.registerClass("AdminPanel.AdhomStoreCom.ProductGrid")],t);$(function(){(0,l.initFullHeightGridPage)(new t($("#GridDiv")).element)});
//# sourceMappingURL=ProductPage.js.map
