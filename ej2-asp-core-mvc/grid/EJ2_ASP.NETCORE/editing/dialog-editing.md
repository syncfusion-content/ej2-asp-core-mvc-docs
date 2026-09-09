---
layout: post
title: ##Platform_Name## Grid Dialog Editing | Syncfusion
description: ##Platform_Name## Grid dialog editing opens record editors in modal dialogs, supports templates, enforces validation, and manages single-record save workflows.
platform: ej2-asp-core-mvc
control: Dialog Editing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Dialog Editing in ASP.NET Core Data Grid

Dialog editing in the Data Grid component provides an efficient way to edit row data through a dedicated modal dialog window that focuses attention on the editing form. Instead of editing cells directly in the grid, multiple field values can be entered and modified at once in a clean, organized form. The grid automatically saves all changes to the data source without navigating away from the current page making data entry faster, more intuitive, and less error-prone, especially when dealing with complex records that span multiple columns.

## Enable dialog editing

To enable dialog editing in the grid component, set the [editSettings.mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property to `Dialog`. This property determines the editing mode for the grid.

The following example demonstrates enabling dialog editing in the Data Grid component:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/dialog/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Dialog editing](../images/editing/dialog-edit.png)

## Wizard-like dialog editing

Wizard-like dialog editing divides complex forms into manageable step-by-step sections with efficient navigation. The [editSettings.template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) property enables custom form templates with multiple steps:

1. Set  [editSettings.mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) to `Dialog`.
2. Define template sections for each form step.
3. Add navigation buttons (Previous, Next, Save) between steps.
4. Implement validation for each step.

The example below demonstrates wizard-like dialog editing in the grid using unobtrusive validation:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/wizardediting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/wizardediting/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Use wizard like dialog editing](../images/editing/dialog-tabs-multiple.gif)

## Customize edit dialog

The edit dialog is a modal window that isolates the editing form and prevents grid interaction until the dialog closes. Customize this dialog to match application needs by handling the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event.

**Customizable options**:
- Header text, close button visibility, and height.
- Button text and localization strings.
- Dialog behavior based on the editing action.

Use the `requestType` parameter to identify which action triggered the event and apply appropriate customizations:

| Request Type | Description |
|--------------|-------------|
| `beginEdit` | Editing an existing record |
| `add` | Creating a new record |
| `save` | Updating a new or existing record |
| `delete` | Deleting an existing record |

> Refer to the Grid [Default text](../global-local) list for localization options.

The following example demonstrates how to customize the edit dialog using the `actionComplete` event:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customizedialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/customizedialog/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Customize edit dialog](../images/editing/dialog-customize.png)

> The Data Grid's add or edit dialog element applies a max-height property that is calculated based on the available window height. For typical screens (1920 x 1080), the dialog's maximum height can be set up to 658px.

## Show or hide columns in dialog editing

Column visibility can be dynamically controlled in dialog editing mode. The [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event enables showing or hiding specific columns based on whether an existing record is being edited or a new record is being added.

The `actionBegin` event is triggered whenever an action is initiated in the grid (editing, adding, or deleting a record). Within the event handler, the `requestType` parameter determines to manage column visibility in the event handler:

| Request Type | Action | Column Visibility Control |
|---|---|---|
| `beginEdit` or `add` | Editing or creating a record | Modify visibility using the `visible` property |
| `save` | Saving the record | Reset columns to initial visibility state using `visible` property |

In the following example, the "Customer ID" column is rendered as a hidden column, and the "Ship Country" column is rendered as a visible column. In the edit mode, the "Customer ID" column will be changed to a visible state and the "Ship Country" column will be changed to a hidden state.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/show-hide-edit-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/show-hide-edit-dialog/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Show or hide columns in dialog editing](../images/editing/dialog-show-hide.png)

## Customize dialog footer

The dialog footer can be customized to add custom buttons or modify button appearance. The default footer displays Save and Cancel buttons. The [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event enables adding custom buttons, changing button text, or implementing custom button actions in the dialog footer.

The following example customizes the action of a custom footer button using the `dialog` argument of the `actionComplete` event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/custombutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="custombutton.cs" %}
{% include code-snippet/grid/edit/custombutton/custombutton.cs %}
{% endhighlight %}
{% endtabs %}

![Customize add/edit dialog footer](../images/editing/dialog-footer.png)