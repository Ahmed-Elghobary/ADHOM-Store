import{a as h}from"../../../_chunks/chunk-DNPINPPP.js";import{a as w}from"../../../_chunks/chunk-B5W2OTS7.js";import{e as x,f as P,g as f,h as o,i as a}from"../../../_chunks/chunk-MNHJHLJ6.js";import{a as s,b as n,c as p,e as R,f as g}from"../../../_chunks/chunk-K3EI6ARL.js";var v=n(R(),1);var I=n(g(),1),e=n(R(),1);var l=class extends I.TemplatedDialog{constructor(t){super(t);this.permissions=new h(this.byId("Permissions"),{showRevoke:!1}),f.List({RoleID:this.options.roleID,Module:null,Submodule:null},y=>{this.permissions.value=y.Entities.map(m=>({PermissionKey:m}))}),this.permissions.implicitPermissions=(0,e.getRemoteData)("Administration.ImplicitPermissions")}getDialogOptions(){let t=super.getDialogOptions();return t.buttons=[{text:(0,e.localText)("Dialogs.OkButton"),click:y=>{f.Update({RoleID:this.options.roleID,Permissions:this.permissions.value.map(m=>m.PermissionKey),Module:null,Submodule:null},m=>{this.dialogClose(),window.setTimeout(()=>(0,e.notifySuccess)((0,e.localText)("Site.RolePermissionDialog.SaveSuccess")),0)})}},{text:(0,e.localText)("Dialogs.CancelButton"),click:()=>this.dialogClose()}],t.title=(0,e.format)((0,e.localText)("Site.RolePermissionDialog.DialogTitle"),this.options.title),t}getTemplate(){return'<div id="~_Permissions"></div>'}};s(l,"RolePermissionDialog");var c=n(g(),1);var S="edit-permissions",i=class extends c.EntityDialog{constructor(){super(...arguments);this.form=new P(this.idPrefix)}getFormKey(){return P.formKey}getIdProperty(){return o.idProperty}getLocalTextPrefix(){return o.localTextPrefix}getNameProperty(){return o.nameProperty}getService(){return a.baseUrl}getToolbarButtons(){let t=super.getToolbarButtons();return t.push({title:w.Site.RolePermissionDialog.EditButton,cssClass:S,icon:"fa-lock text-green",onClick:()=>{new l({roleID:this.entity.RoleId,title:this.entity.RoleName}).dialogOpen()}}),t}updateInterface(){super.updateInterface(),this.toolbar.findButton(S).toggleClass("disabled",this.isNewOrDeleted())}};s(i,"RoleDialog"),i=p([c.Decorators.registerClass("AdminPanel.Administration.RoleDialog")],i);var d=n(g(),1);var r=class extends d.EntityGrid{getColumnsKey(){return x.columnsKey}getDialogType(){return i}getIdProperty(){return o.idProperty}getLocalTextPrefix(){return o.localTextPrefix}getService(){return a.baseUrl}constructor(u){super(u)}getDefaultSortBy(){return[o.Fields.RoleName]}};s(r,"RoleGrid"),r=p([d.Decorators.registerClass("AdminPanel.Administration.RoleGrid")],r);$(function(){(0,v.initFullHeightGridPage)(new r($("#GridDiv")).element)});
//# sourceMappingURL=RolePage.js.map
