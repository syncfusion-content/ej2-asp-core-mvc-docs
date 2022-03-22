---
layout: post
title: Cross-Site Scripting in ##Platform_Name## Common Control
description: Learn here all about Cross-Site Scripting in Syncfusion ##Platform_Name## Common control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Cross-Site Scripting (XSS)

Cross-Site Scripting is a security vulnerability and a client-side injection attack. Attackers inject the malicious code in a web application, usually JavaScript but could also be HTML or CSS. To prevent this aspect, the API `EnableHtmlSanitizer` is provided and its default value is set to true.

## EnableHtmlSanitizer Supported Controls

The following list demonstrates the Syncfusion ASP.NET Core controls that are supported with `EnableHtmlSanitizer` property.

* [Accordion](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Accordion.html#Syncfusion_EJ2_Navigations_Accordion_EnableHtmlSanitizer)
* [Button](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_EnableHtmlSanitizer)
* [CheckBox](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_EnableHtmlSanitizer)
* [ContextMenu](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_EnableHtmlSanitizer)
* [DashboardLayout](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.DashboardLayout.html#Syncfusion_EJ2_Layouts_DashboardLayout_EnableHtmlSanitizer)
* [Dialog](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_EnableHtmlSanitizer)
* [DropDownButton](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_EnableHtmlSanitizer)
* [FileManager](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.FileManager.FileManager.html#Syncfusion_EJ2_FileManager_FileManager_EnableHtmlSanitizer)
* [InPlaceEditor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_EnableHtmlSanitizer)
* [ListView](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Lists.ListView.html#Syncfusion_EJ2_Lists_ListView_EnableHtmlSanitizer)
* [Menu](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Menu.html#Syncfusion_EJ2_Navigations_Menu_EnableHtmlSanitizer)
* [MultiSelect](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_EnableHtmlSanitizer)
* [PivotView](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnableHtmlSanitizer)
* [ProgressButton](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_EnableHtmlSanitizer)
* [RadioButton](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.RadioButton.html#Syncfusion_EJ2_Buttons_RadioButton_EnableHtmlSanitizer)
* [RichTextEditor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_EnableHtmlSanitizer)
* [Slider](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.Slider.html#Syncfusion_EJ2_Inputs_Slider_EnableHtmlSanitizer)
* [SplitButton](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_EnableHtmlSanitizer)
* [Splitter](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_EnableHtmlSanitizer)
* [Tab](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_EnableHtmlSanitizer)
* [Toast](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_EnableHtmlSanitizer)
* [ToolBar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ToolbarBuilder.html#Syncfusion_EJ2_Navigations_ToolbarBuilder_EnableHtmlSanitizer_System_Boolean_)
* [Tooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Tooltip.html#Syncfusion_EJ2_Popups_Tooltip_EnableHtmlSanitizer)
* [TreeView](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_EnableHtmlSanitizer)

## See also

* [Develop an ASP.NET Core web application securely](https://www.syncfusion.com/blogs/post/10-practices-secure-asp-net-core-mvc-app.aspx)
* [Perform CRUD operation in Grid control using anti-forgery token](../grid/how-to/perform-crud-operation-using-anti-forgery-token)
* [Prevent cross-site scripting in RichTextEditor control](../rich-text-editor/miscellaneous#prevention-of-cross-site-scripting-xss)