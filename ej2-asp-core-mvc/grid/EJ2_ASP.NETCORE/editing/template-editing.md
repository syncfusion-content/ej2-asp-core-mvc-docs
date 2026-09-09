---
layout: post
title: ##Platform_Name## Grid Custom Template Editing | Syncfusion
description: Learn how to use Inline and Dialog Template Editing in ##Platform_Name## Data Grid to customize edit forms, capture user input, and manage CRUD operations.
platform: ej2-asp-core-mvc
control: Template Editing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom Template Editing in ASP.NET Core Data Grid

The Data Grid supports template editing for creating fully customized inline and dialog-based edit forms. Template editing enables the use of Reactive Forms, Template-driven Forms, custom editors, validation logic, additional form fields, and advanced editing layouts tailored to application requirements.

> For grid basic editing setup and configuration, refer to the [Edit Feature Setup](./edit#set-up-editing).

## Inline or dialog template editing

Dialog and inline template editing provide options to customize the default behavior of the edit dialog. By setting the [editSettings.mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property to `Dialog` or `Inline`, and defining the [editSetting.template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) property as a script element ID or an HTML string, custom editors can be rendered within the dialog.

**Using Forms**

Forms is a approach to create and manipulate the form controls. You can use form to add and update grid records. To use forms for editing operation, you can take leverage of the template support of dialog or inline edit mode. Setting the [editSettings.mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) as **Normal/Dialog** and use [editSetting.template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) property to specify a SCRIPT element ID or an HTML string that holds the template.

In some cases, you want to add new field editors in the dialog which are not present in the column model. In that situation the dialog template will help us to customize the default edit dialog.

In the following sample, grid enabled with dialog template editing.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dialogtemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AddPartial.cshtml" %}
{% include code-snippet/grid/edit/dialogtemplate/addpatial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EditPartial.cshtml" %}
{% include code-snippet/grid/edit/dialogtemplate/editpartial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="dialogData.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialogData.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DialogTemplateModel.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialogtemplatemodel.cs %}
{% endhighlight %}
{% endtabs %}

| Add | Edit |
| -------------- | ------------- |
| ![Add](../images/editing/template-inline-add.png) | ![Edit](../images/editing/template-inline-edit.png) |

> The template form editors should have **name** attribute.

## Using template context

You can enhance the customization of your grid's edit forms by utilizing template contexts, such as accessing row details inside template, rendering editors as components, getting values from editors, setting focus to editors, and disabling default form validation, and adding custom validation. These features are applicable in both **inline** and **dialog** editing modes.

The following template context topics are demonstrated through a practical example in the [Render tab component inside the dialog template](https://ej2.syncfusion.com/aspnetcore/documentation/grid/editing/template-editing#render-tab-component-inside-the-dialog-template) topic.

### Access row details inside template

Edit templates provide access to crucial row information within an `template`. This enables dynamic binding of attributes, values, or elements based on the specific row being edited, and supports conditional rendering or modification of elements in the edit template based on the row's state.

The following properties will be available at the time of template execution:

| Property Name | Usage |
|---------------|-------|
| `isAdd` | A Boolean property that defines whether the current row is a new record or not. |

The following code example demonstrates the usage of the `isAdd` property in an edit template to disable the OrderID textbox when it's not a new record:

```ts
    <input id="OrderID" name="OrderID" type="text" value=${if(isAdd)} '' ${else} ${OrderID} ${/if}  ${if(isAdd)}'' ${else} disabled ${/if}/>
```

### Render editors as components 

The Data Grid provides a powerful feature enabling dynamic rendering of Syncfusion<sup style="font-size:70%">&reg;</sup> EJ2 controls as form editors during the editing process. This functionality delivers feature-rich controls for data entry within the edit form.

To achieve this by utilizing the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event of the Grid and specifying `requestType` as **beginEdit** or **add**.

The following code example illustrates rendering the [DropDownList](https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-list/getting-started) component in the `actionComplete` event.

```js

    function actionComplete(args) {
        if ((args.requestType === 'beginEdit' || args.requestType === 'add')) {
            var countryData = ej.data.DataUtil.distinct(@Html.Raw(JsonConvert.SerializeObject(ViewBag.dataSource)), 'ShipCountry', true);;
            new DropDownList({value: args.rowData.ShipCountry, popupHeight: '200px', floatLabelType: 'Always',
                dataSource: countryData, fields: {text: 'ShipCountry', value: 'ShipCountry'}, placeholder: 'Ship Country'}, args.form.elements.namedItem('ShipCountry'));
        }
    }

```

### Get value from editor

The get value from editor feature in the Data Grid enables reading, formatting, and updating the current editor value before saving. This feature provides significant value when specific actions must be performed on data, such as formatting or validation, before committing to the underlying data source. 

To implement this feature, utilize the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event with the `requestType` set to `save`.

In the following code example, the freight value has been formatted and updated.
 
```ts
    function actionBegin(args) {
        if (args.requestType === 'save') {
            // cast string to integer value.
            args.data['Freight'] = parseFloat(args.form.querySelector("#Freight").value);
        }
    }

```

### Set focus to particular column editor 

The Data Grid enables control of focus behavior for input elements in edit forms. By default, the first input element in the dialog receives focus when the dialog is opened. However, when the first input element is disabled or hidden, a different valid input element can receive focus. This can be achieved using the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event of the grid, where the `requestType` is set to `beginEdit`.

In the following code example, the CustomerID column focused.
 
```ts

    function actionComplete(args) {
        // Set initail Focus
        if (args.requestType === 'beginEdit') {
            (args.form.elements.namedItem('CustomerID')).focus();
        }
    }

```

### Disable default form validation

Default validation rules can be disabled by handling the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event in the Data Grid component. This event provides access to the editing lifecycle, allowing customization of validation behavior when records are added or updated.

```typescript

    function actionComplete: (args) {
        if ((args.requestType === 'beginEdit' || args.requestType === 'add')) {
            // Disable the Validation Rules
            args.form.ej2_instances[0].removeRules();
        }
    }

```
> Disabling validation rules in the Data Grid can be achieved by setting : `args.form.ej2_instances[0].rules = {}`.

### Add validation rules for custom editors

The Data Grid provides the ability to add validation rules for fields not present in the column model. This feature prevents erroneous or inconsistent data from being submitted, enhancing the reliability of application data.

To add validation rules, utilize the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event along with the [addRules](../../api/form-validator#addrules) method. The following approach uses the `addRules` method to add validation rules for custom editors in the `actionComplete` event:
 
```ts

    function actionComplete(args) {
        if ((args.requestType === 'beginEdit' || args.requestType === 'add')) {
            // Add Validation Rules
            args.form.ej2_instances[0].addRules('Freight', {max: 500});
        }
    }

```

## Render tab component inside the dialog template

Rendering a [Tab](https://ej2.syncfusion.com/aspnetcore/documentation/tab/getting-started) component inside the dialog template enhances the grid editing experience. This feature is especially useful for presenting multiple editing sections or categories in a tabbed layout, ensuring a more intuitive and easily navigable interface for data editing.

Enable dialog mode with  [editSettings.mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) set to `Dialog`. Place the `Tab` component inside [editSettings.template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template).

In the following example, a tab component is rendered inside the edit dialog. The tab component contains two tabs. Once the first tab is filled and navigation occurs to the second tab, validation for the first tab is performed before moving to the second.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/tabediting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/tabediting/dialog.cs %}
{% endhighlight %}
{% endtabs %}

![Render tab control inside the dialog template](../images/editing/template-tab.gif)

