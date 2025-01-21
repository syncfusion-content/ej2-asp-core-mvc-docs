---
layout: post
title: Dialog Editing in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Dialog Editing in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Dialog Editing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Dialog editing in ASP.NET MVC Grid component

Dialog editing is a feature in the Grid component that allows you to edit the data of the currently selected row using a dialog window. With dialog editing, you can easily modify cell values and save the changes back to the data source.This feature is particularly beneficial in scenarios where you need to quickly modify data without navigating to a separate page or view, and it streamlines the process of editing multiple cells.

To enable dialog editing in grid component, you need to set the [EditSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property to **Dialog**. This property determines the editing mode for the grid, and when set to **Dialog**, it enables the dialog editing feature.

Here's an example how to enable dialog editing in the ASP.NET MVC grid component:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/dialog/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Dialog editing](../images/editing/dialog-edit.png)

## Customize edit dialog

The edit dialog in the Grid component allows you to customize its appearance and behavior based on the type of action being performed, such as editing or adding a record. You can modify properties like header text, showCloseIcon, and height to tailor the edit dialog to your specific requirements. Additionally, you can override default localization strings to provide custom text for buttons or other elements within the dialog.

To customize the edit dialog, you need to handle the [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event of the Grid component and perform the necessary modifications based on the **requestType** parameter. The **requestType** parameter identifies the type of action being performed, such as **beginEdit** for editing a record or **add** for adding a new record.

>You can refer the Grid [Default text](../global-local/) list for more localization.

The following example that demonstrates how to customize the edit dialog using the `ActionComplete` event:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customizedialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/customizedialog/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Customize edit dialog](../images/editing/dialog-customize.png)

> The Grid add or edit dialog element has the max-height property, which is calculated based on the available window height. So, in the normal window (1920 x 1080), it is possible to set the dialog's height up to 658px.

## Show or hide columns in dialog editing

The show or hide columns in dialog editing feature in the grid allows you to dynamically control the visibility of columns while editing in the dialog edit mode. This feature is useful when you want to display specific columns based on the type of action being performed, such as editing an existing record or adding a new record. To achieve this, you can utilize the [ActionBegin](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event of the Grid. 

The `ActionBegin` event is triggered whenever an action is initiated in the grid, such as editing, adding, or deleting a record. Within the event handler, you can check the **requestType** parameter to determine the type of action being performed. If the **requestType** is `beginEdit` or `add`, you can modify the visibility of columns using the `Column.Visible` property. This property is used to determine whether a column should be displayed or hidden. Then, when the **requestType** is `save`, you can reset the column visibility to its initial state using the `Column.Visible` property.

In the following example, the **CustomerID** column is rendered as a hidden column, and the **ShipCountry** column is rendered as a visible column. In the edit mode, the **CustomerID** column will be changed to a visible state and the **ShipCountry** column will be changed to a hidden state.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/show-hide-edit-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/show-hide-edit-dialog/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Show or hide columns in dialog editing](../images/editing/dialog-show-hide.png)

## Use wizard like dialog editing

Wizard-like dialog editing is a powerful feature in the Grid component that enables the creation of intuitive step-by-step forms. This feature provides a structured approach to form completion or data entry by breaking down the process into manageable steps.This feature is particularly useful when you have complex forms that need to be broken down into smaller sections to guide you through the data entry process.

To achieve wizard-like dialog editing in the grid component, you can use the dialog template feature. This feature allows you to define your own custom editing template using the [EditSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property set to  **Dialog** and the [EditSettings.Template](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) property to specify the template variable that defines the editors for each step of the wizard.

The following example demonstrate the wizard like editing in the grid with the unobtrusive validation.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/wizardediting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/wizardediting/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Use wizard like dialog editing](../images/editing/dialog-tabs-multiple.gif)

## Customize add/edit dialog footer

The Customize add/edit dialog footer feature in the grid allows you to modify the footer section of the dialog that appears when editing the currently selected row or adding a new row. By default, the dialog displays two buttons in the footer section: Save and Cancel, which allow you to save or discard the changes made in the dialog. This feature is particularly helpful when you want to add custom buttons to the dialog's footer, implement specific actions, or customize the appearance of the buttons, such as changing their color or size in the dialog's footer. This can be achieved using the [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event of the Grid component.

In the following sample, using the `dialog` argument of the `ActionComplete` event, the action for the custom button can be customized.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/custombutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="custombutton.cs" %}
{% include code-snippet/grid/edit/custombutton/custombutton.cs %}
{% endhighlight %}
{% endtabs %}

![Customize add/edit dialog footer](../images/editing/dialog-footer.png)