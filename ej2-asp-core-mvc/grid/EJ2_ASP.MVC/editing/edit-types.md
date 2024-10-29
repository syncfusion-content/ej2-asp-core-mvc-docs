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

The Syncfusion Grid provides pre-built default editors that enhance data editing and input handling within the grid. These default editors are designed to simplify the process of defining the editor component for specific columns based on the data type of the column within the grid. To configure default editors for grid columns, leverage the `EditType` property.

The available default edit types are as follows:

Component|Edit Type value |Description
----|-----|-----
[TextBox](../../textbox)|stringedit	|  The  `stringedit` type renders a TextBox component for string data type columns. 
[NumericTextBox](../../numerictextbox)|numericedit	| The `numericedit` type renders a NumericTextBox component for integers,double,float ,short ,byte ,long ,long double and decimal data types columns.
[DropDownList](../../drop-down-list)|dropdownedit	| The `dropdownedit` type renders a DropdownList component for string data type columns.
[Checkbox](../../check-box)|booleanedit	| The `booleanedit` type renders a CheckBox component for boolean data type columns.
[DatePicker](../../datepicker)|datepickeredit	|The `datepickeredit` type renders a DatePicker component for date data type columns.
[DateTimePicker](../../datetimepicker)|datetimepickeredit	| The `datetimepickeredit` type renders a DateTimePicker component for date time data type columns.

The following example demonstrates how to define the `EditType` for grid columns:

```c#
    col.Field("CustomerName").HeaderText("Customer Name").EditType("stringedit").Add();
    col.Field("Frieght").HeaderText("Frieght").EditType("numericedit").Add();
    col.Field("ShipCountry").HeaderText("Ship Country").EditType("dropdownedit").Add();
    col.Field("OrderDate").HeaderText("Order Date").EditType("datepickeredit").Add();
    col.Field("OrderTime").HeaderText("Order Time").EditType("datetimepickeredit").Add();
    col.Field("Verified").HeaderText("Verified").EditType("booleanedit").Add();
```
> If edit type is not defined in the column, then it will be considered as the **stringedit** type (TextBox component).

## Customize TextBox component of stringedit type 

You can customize the default TextBox component in Grid edit form using its property. This customization allows you to configure various properties of the TexBox, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `Columns->Edit->Params` property.

Component|Edit Type |Description|Example Customized edit params
-----|---|-----|-----|
[TextBox](../../textbox) |stringedit| The `stringedit` type renders a TextBox component for string data type columns. To customize the `TextBox` component, refer to the [TextBox API documentation](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.inputs.textbox.html#properties) for detailed information on available properties | params: { showClearButton : true}

The following sample code demonstrates the customization applied to TextBox component of **CustomerID** Grid column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/textbox-edit-params/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Textbox-params.cs" %}
{% include code-snippet/grid/edit/textbox-edit-params/textbox-params.cs %}
{% endhighlight %}
{% endtabs %}

## Customize NumericTextBox component of numericedit type 

You can customize the `NumericTextBox` component in Grid edit form using its property. This customization allows you to configure various properties of the NumericTextBox, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `Columns->Edit->Params` property.

Component| Edit Type |Description |Example Customized edit params
-----|-----|-----|----|
[NumericTextBox](../../numerictextbox)|numericedit| TThe `numericedit` type renders a NumericTextBox component for integers, double, float, short, byte, long, long double and decimal data types columns. To customize the **NumericTextBox** component, refer to the [NumericTextBox API documentation](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.inputs.numerictextbox.html) for detailed information on available properties. | params: { decimals: 2, value: 5 }

The following sample code demonstrates the customization applied to NumericTextBox component of **Frieght** Grid column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/numeric-edit-params/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric-textbox-params.cs" %}
{% include code-snippet/grid/edit/numeric-edit-params/numeric-params.cs %}
{% endhighlight %}
{% endtabs %}

### Restrict to type decimal points in a NumericTextBox while editing the numeric column

By default, the `NumericTextBox` component allows entering decimal values with up to two decimal places when editing a numeric column. However, there might be cases where you want to restrict input to whole numbers only, without any decimal points. In such scenarios, you can make use of the [ValidateDecimalOnType](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.inputs.numerictextbox.html#Syncfusion_EJ2_Inputs_NumericTextBox_ValidateDecimalOnType) and [Decimals](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.inputs.numerictextbox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Decimals) properties provided by Syncfusion's `NumericTextBox` component.

The `ValidateDecimalOnType` property is used to control whether decimal points are allowed during input in the NumericTextBox. By default, it is set to **false**, allowing decimal points to be entered. However, when set to **true**, decimal points will be restricted, and only whole numbers can be entered.

The `Decimals` property specifies the number of decimal places to be displayed in the NumericTextBox. By default, it is set to 2, meaning that two decimal places will be displayed. However, you can modify this value to customize the decimal places according to your requirements.

In the below demo, while editing the row the decimal point value is restricted to type in the NumericTextBox of **Freight** column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/prevent-decimal-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-decimal-value.cs" %}
{% include code-snippet/grid/edit/prevent-decimal-point/decimal-value.cs %}
{% endhighlight %}
{% endtabs %}

## Customize DropDownList component of DropDownEdit type 

You can customize the `DropDownList` component in Grid edit form using its property. This customization allows you to configure various properties of the DropDownList, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `Columns->Edit->Params` property. 

Component|Edit Type |Description| Example Customized edit params
-----|-----|-----|----|
[DropDownList](../../drop-down-list)-|DropDownEdit|  The `dropdownedit` type renders a DropDownList component for string data type columns. To customize the DropDownList component, refer to the [DropDownList API documentation](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.dropdowns.dropdownlist.html) for detailed information on available properties.  | params: { value: ‘Germany’ }

The following sample code demonstrates the customization applied to DropDownList component  of **ShipCity** Grid column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-edit-params/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric-textbox-params.cs" %}
{% include code-snippet/grid/edit/dropdown-edit-params/dropdown-params.cs %}
{% endhighlight %}
{% endtabs %}

### Provide custom data source and enabling filtering to DropDownList

You can provide data source to the DropDownList by using **params** property of [`Edit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Edit) in [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

While setting new data source using edit params, you must specify a new **query** property too for the DropDownList as follows,

```typescript
@{
    var DropDownList = new Syncfusion.EJ2.DropDowns.DropDownList() { DataSource = ViewBag.DropDownData, Query = "new ej.data.Query()", Fields = new Syncfusion.EJ2.DropDowns.DropDownListFieldSettings() { Value = "Country", Text = "Country" }, AllowFiltering = true, ActionComplete="actionComplete" };
}
{
    col.Field("ShipName").HeaderText("ShipName").Width("150").EditType("dropdownedit").Edit(new { @params = DropDownList }).Add();
}
```

You can also enable filtering for the DropDownList by passing the **allowFiltering** as **true** to the edit params.

In the below demo, DropDownList is rendered with custom Datasource for the **ShipCountry** column and enabled filtering to search DropDownList items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/dropdown-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-dropdownlist.cs" %}
{% include code-snippet/grid/how-to/dropdown-edit/edit-dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/dropdown-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Edit-dropdownlist.cs" %}
{% include code-snippet/grid/how-to/dropdown-edit/edit-dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



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

Use the cell edit template feature of the Grid to render the RichTextEditor component in the Grid edit form. In the below sample, we have rendered RichTextEditor component in the **ShipAddress** column, so we use [AllowTextWrap](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowTextWrap) property to true.

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

The DropDownList has been provided with several options to customize each list item, group title, selected value, header, and footer element. By default, list items can be rendered as a single column in the DropDownList component. Instead of this, multiple columns can be rendered. This can be achieved by using the [headerTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_HeaderTemplate) and [itemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ItemTemplate) properties of the DropDownList component.

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

In the below demo, you can access the Editor component instance while adding or editing actions on the [`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event.

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

