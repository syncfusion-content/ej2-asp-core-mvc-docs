---
layout: post
title: Edit Types in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Edit Types in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Edit Types
publishingplatform: ##Platform_Name##
documentation: ug
---

# Edit Types in ASP.NET Core Grid Component

The ASP.NET Core Grid component in Syncfusion provides various edit types that allow you to customize the editing behavior for different types of columns. These edit types enhance the editing experience and provide flexibility in handling different data types. 

The Syncfusion Grid provides pre-built default editors that enhance data editing and input handling within the grid. These default editors are designed to simplify the process of defining the editor component for specific columns based on the data type of the column within the grid. To configure default editors for grid columns, leverage the `editType` property.

The available default edit types are as follows:

Component|Edit Type value |Description
----|-----|-----
[TextBox](../../textbox)|stringedit	|  The  `stringedit` type renders a TextBox component for string data type columns. 
[NumericTextBox](../../numerictextbox)|numericedit	| The `numericedit` type renders a NumericTextBox component for integers,double,float ,short ,byte ,long ,long double and decimal data types columns.
[DropDownList](../../drop-down-list)|dropdownedit	| The `dropdownedit` type renders a DropdownList component for string data type columns.
[Checkbox](../../check-box)|booleanedit	| The `booleanedit` type renders a CheckBox component for boolean data type columns.
[DatePicker](../../datepicker)|datepickeredit	|The `datepickeredit` type renders a DatePicker component for date data type columns.
[DateTimePicker](../../datetimepicker)|datetimepickeredit	| The `datetimepickeredit` type renders a DateTimePicker component for date time data type columns.

The following example demonstrates how to define the `editType` for grid columns:

```html
    <e-grid-column field="CustomerName" headerText="Customer Name" editType="stringedit"></e-grid-column>
    <e-grid-column field="Frieght" headerText="Frieght" editType="numericedit'"></e-grid-column>
    <e-grid-column field="ShipCountry" headerText="Ship Country" editType="dropdownedit"></e-grid-column>
    <e-grid-column field="OrderDate" headerText="Order Date" editType="datepickeredit"></e-grid-column>
    <e-grid-column field="OrderTime" headerText="Order Time" editType="datetimepickeredit"></e-grid-column>
    <e-grid-column field="Verified" headerText="Verified" editType="booleanedit"></e-grid-column>
```

> If edit type is not defined in the column, then it will be considered as the **stringedit** type (TextBox component).

## Customize TextBox component of stringedit type 

You can customize the default TextBox component in Grid edit form using its property. This customization allows you to configure various properties of the TexBox, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `columns->edit->params` property.

Component|Edit Type |Description|Example Customized edit params
-----|---|-----|-----|
[TextBox](../../textbox) |stringedit| The `stringedit` type renders a TextBox component for string data type columns. To customize the `TextBox` component, refer to the [TextBox API documentation](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.textbox.html#properties) for detailed information on available properties | params: { showClearButton : true}

The following sample code demonstrates the customization applied to TextBox component of **CustomerID** Grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/textbox-edit-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Textbox-params.cs" %}
{% include code-snippet/grid/edit/textbox-edit-params/textbox-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize textbox edit type](../images/editing/textbox-edit-type.png)

## Customize NumericTextBox component of numericedit type 

You can customize the `NumericTextBox` component in Grid edit form using its property. This customization allows you to configure various properties of the NumericTextBox, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `columns->edit->params` property.

Component| Edit Type |Description |Example Customized edit params
-----|-----|-----|----|
[NumericTextBox](../../numerictextbox)|numericedit| TThe `numericedit` type renders a NumericTextBox component for integers, double, float, short, byte, long, long double and decimal data types columns. To customize the **NumericTextBox** component, refer to the [NumericTextBox API documentation](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.numerictextbox.html) for detailed information on available properties. | params: { decimals: 2, value: 5 }

The following sample code demonstrates the customization applied to NumericTextBox component of **Frieght** Grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/numeric-edit-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric-textbox-params.cs" %}
{% include code-snippet/grid/edit/numeric-edit-params/numeric-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize numeric textbox edit type](../images/editing/numeric-textbox-edit-type.png)

### Restrict to type decimal points in a NumericTextBox while editing the numeric column

By default, the `NumericTextBox` component allows entering decimal values with up to two decimal places when editing a numeric column. However, there might be cases where you want to restrict input to whole numbers only, without any decimal points. In such scenarios, you can make use of the [validateDecimalOnType](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.numerictextbox.html#Syncfusion_EJ2_Inputs_NumericTextBox_ValidateDecimalOnType) and [decimals](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.numerictextbox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Decimals) properties provided by Syncfusion's `NumericTextBox` component.

The `validateDecimalOnType` property is used to control whether decimal points are allowed during input in the NumericTextBox. By default, it is set to **false**, allowing decimal points to be entered. However, when set to **true**, decimal points will be restricted, and only whole numbers can be entered.

The `decimals` property specifies the number of decimal places to be displayed in the NumericTextBox. By default, it is set to 2, meaning that two decimal places will be displayed. However, you can modify this value to customize the decimal places according to your requirements.

In the below demo, while editing the row the decimal point value is restricted to type in the NumericTextBox of **Freight** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/prevent-decimal-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-decimal-point.cs" %}
{% include code-snippet/grid/edit/prevent-decimal-point/decimal-value.cs %}
{% endhighlight %}
{% endtabs %}

![Customize decimal points in numeric textbox](../images/editing/numeric-textbox-decimal-values.png)

## Customize DropDownList component of DropDownEdit type 

You can customize the `DropDownList` component in Grid edit form using its property. This customization allows you to configure various properties of the DropDownList, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `columns->edit->params` property. 

Component|Edit Type |Description| Example Customized edit params
-----|-----|-----|----|
[DropDownList](../../drop-down-list)-|DropDownEdit|  The `dropdownedit` type renders a DropDownList component for string data type columns. To customize the DropDownList component, refer to the [DropDownList API documentation](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdownlist.html) for detailed information on available properties.  | params: { value: ‘Germany’ }

The following sample code demonstrates the customization applied to DropDownList component  of **ShipCity** Grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-edit-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dropdownlist-params.cs" %}
{% include code-snippet/grid/edit/dropdown-edit-params/dropdown-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize dropdown edit type](../images/editing/dropdown-edit-type.png)

### Provide custom data source for DropDownList component

In Syncfusion's Grid component, you have an option to provide a custom data source for the `DropDownList` component in the edit form. This feature allows you to define a specific set of values for the DropDownList.

To achieve this, you can utilize the `columns->edit->params` property. This property allows you to define the edit params for the column within the grid.

When setting a new data source using the edit params, you need to specify a new [query](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdownlist.html#Syncfusion_EJ2_DropDowns_DropDownList_Query) property for the DropDownList. The `query` property allows you to define custom queries for data retrieval and filtering.

In the below demo, DropDownList is rendered with custom data source for the **ShipCountry** column :

### Apply filtering for DropDownList component

The Syncfusion Grid component provides filtering for the DropDownList within the edit form. This feature allows to select options from a predefined list and easily search for specific items using the built-in filtering feature.  

To enable filtering, set the [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdownlist.html#Syncfusion_EJ2_DropDowns_DropDownList_AllowFiltering) property to **true** within the edit params. This will enable the filtering feature in the DropDownList.

In the following demo, filtering is enabled for the **ShipCountry** column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-filter-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filter-dropdownlist.cs" %}
{% include code-snippet/grid/edit/dropdown-filter-edit/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Customize dropdown edit type](../images/editing/filtering-for-dropdown.gif)

### Open popup while focusing in the edit cell

You can open the dropdown edit popup with a single click by focusing the dropdown element. This feature allows you to quickly access and interact with the dropdown options without the need for an additional click.

To achieve this, you can utilize the `showPopup` method provided by the EJ2 DropDownList component. This method can be invoked within the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event of the Grid, which triggers when an action, such as editing, is completed. By calling the `showPopup` method in this event, you can open the popup for the dropdown edit.

To ensure that the dropdown column is the clicked edit target, you need to set a global flag variable in the **mouseup** event along with [load](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) event. This flag variable will be used to determine if the clicked element corresponds to the dropdown column.

The following sample demonstrates how to open the popup when focusing on the edit cell using the `actionComplete` and `load` events:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-popup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popup-dropdownlist.cs" %}
{% include code-snippet/grid/edit/dropdown-popup/dropdown-popup.cs %}
{% endhighlight %}
{% endtabs %}

![Customize dropdown edit type](../images/editing/dropdown-popup.gif)

## Customize CheckBox component of booleanedit type 

You can customize the CheckBox component in Grid edit form using its property. This customization allows you to configure various properties of the CheckBox, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `columns->edit->params` property.

Component| Edit Type |Description |Example Customized edit params
-----|-----|-----|----|
[CheckBox](../../check-box)| booleanedit | The `booleanedit` type renders a **CheckBox** component for boolean data type. To customize the CheckBox component, refer to the [CheckBox API documentation](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.checkbox.html) for detailed information on available properties. | params: { checked: true}

The following sample code demonstrates the customization applied to CheckBox component of **Verified** Grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/checkbox-edit-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Check-box-params.cs" %}
{% include code-snippet/grid/edit/checkbox-edit-params/checkbox-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize check box edit type](../images/editing/checkbox-edit-type.png)

## Custom editors using template

The cell edit template is used to add a custom component for a particular column by invoking the following functions:

* **create** - It is used to create the element at the time of initialization.

* **write** - It is used to create the custom component or assign default value at the time of editing.

* **read** - It is used to read the value from the component at the time of save.

* **destroy** - It is used to destroy the component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/celledittemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Celledittemplate.cs" %}
{% include code-snippet/grid/edit/celledittemplate/celledittemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/celledittemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Celledittemplate.cs" %}
{% include code-snippet/grid/edit/celledittemplate/celledittemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Render TimePicker component while editing

Use the cell edit template feature of the Grid to render the TimePicker component in the Grid edit form. In the below sample, we have rendered TimePicker component in the **OrderDate** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/timepicker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TimePicker.cs" %}
{% include code-snippet/grid/edit/timepicker/timepicker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/timepicker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TimePicker.cs" %}
{% include code-snippet/grid/edit/timepicker/timepicker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Render AutoComplete component while editing

Use the cell edit template feature of the Grid to render the AutoComplete component in the Grid edit form. In the below sample, we have rendered AutoComplete component in the **CustomerID** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/autocomplete/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoComplete.cs" %}
{% include code-snippet/grid/edit/autocomplete/autocomplete.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/autoComplete/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autocomplete.cs" %}
{% include code-snippet/grid/edit/autocomplete/autocomplete.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Render MultiSelect DropDown component while editing

Use the cell edit template feature of the Grid to render the MultiSelect DropDown component in the Grid edit form. In the below sample, we have rendered MultiSelect DropDown component in the **ShipCity** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/multiselect/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MultiSelect.cs" %}
{% include code-snippet/grid/edit/multiselect/multiselect.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/multiselect/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MultiSelect.cs" %}
{% include code-snippet/grid/edit/multiselect/multiselect.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Render MaskedTextBox component while editing

Use the cell edit template feature of the Grid to render the MaskedTextBox component in the Grid edit form. In the following sample, the MaskedTextBox component is rendered in the Mask column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/masktextbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Masktextbox.cs" %}
{% include code-snippet/grid/edit/masktextbox/masktextbox.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/masktextbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Masktextbox.cs" %}
{% include code-snippet/grid/edit/masktextbox/Masktextbox.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Render RichTextEditor component while editing

Use the cell edit template feature of the Grid to render the RichTextEditor component in the Grid edit form. In the below sample, we have rendered RichTextEditor component in the **ShipAddress** column, so we use [allowTextWrap](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowTextWrap) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/rte/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RTE.cs" %}
{% include code-snippet/grid/edit/rte/rte.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/rte/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RTE.cs" %}
{% include code-snippet/grid/edit/rte/rte.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Render multiple columns in DropDownList component while editing

Use the cell edit template feature of the Grid to render the DropDownList component in the Grid edit form.

The DropDownList has been provided with several options to customize each list item, group title, selected value, header, and footer element. By default, list items can be rendered as a single column in the DropDownList component. Instead of this, multiple columns can be rendered. This can be achieved by using the [headerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_HeaderTemplate) and [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ItemTemplate) properties of the DropDownList component.

This is demonstrated in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/multicolumn-dropdown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multicolumn-Dropdown.cs" %}
{% include code-snippet/grid/edit/multicolumn-dropdown/multicolumn-dropdown.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/multicolumn-dropdown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multicolumn-Dropdown.cs" %}
{% include code-snippet/grid/edit/multicolumn-dropdown/multicolumn-dropdown.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Access editor components

You can access the component instance from the component element using the **ej2_instances** property.

In the below demo, you can access the Editor component instance while adding or editing actions in the [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/access-editor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Access-editor.cs" %}
{% include code-snippet/grid/how-to/access-editor/access-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/access-editor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Access-editor.cs" %}
{% include code-snippet/grid/how-to/access-editor/access-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

