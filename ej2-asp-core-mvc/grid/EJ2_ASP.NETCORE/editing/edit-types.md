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

## Customize editors using params

The [`editType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_EditType) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) tag helper is used to define the editor component for any particular column.

You can set the [`editType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_EditType) based on data type of the column.

* **NumericTextBox** component for integers, double, and decimal data types.

* **TextBox** component for string data type.

* **DropDownList** component to show all unique values related to that field.

* **CheckBox** component for boolean data type.

* **DatePicker** component for date data type.

* **DateTimePicker** component for date time data type.

Also, you can customize the behavior of the editor component through [`edit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Edit) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Columns) tag helper .

The following table describes cell edit type and their corresponding edit params of the column.

Component |Example
-----|-----
`NumericTextBox` | params: { decimals: 2, value: 5 }
`DropDownList` | params: { value: 'Germany' }
`Checkbox` | params: { checked: true}
`DatePicker` | params: { format:'dd.MM.yyyy' }
`DateTimePicker` | params: { value: new Date() }

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/celleditparams/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Celleditparams.cs" %}
{% include code-snippet/grid/edit/celleditparams/celleditparams.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/celleditparams/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Celleditparams.cs" %}
{% include code-snippet/grid/edit/celleditparams/celleditparams.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If edit type is not defined in the column, then it will be considered as the **stringedit** type (Textbox component).

### Restrict to type decimal points in a NumericTextBox while editing the numeric column

By default, the number of decimal places will be restricted to two in the NumericTextBox while editing the numeric column. We can restrict to type the decimal points in a NumericTextBox by using the **validateDecimalOnType** and **decimals** properties of NumericTextBox.

In the below demo, while editing the row we have restricted to type the decimal point value in the NumericTextBox of **Freight** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-decimal-point.cs" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/prevent-decimal-point.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-decimal-point.cs" %}
{% include code-snippet/grid/how-to/prevent-decimal-point/prevent-decimal-point.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Provide custom data source and enabling filtering to DropDownList

You can provide data source to the DropDownList by using the **params** of [`edit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_Edit) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

While setting new data source using edit params, you must specify a new **query** property too for the DropDownList as follows,

```typescript
@{
    var DropDownList = new Syncfusion.EJ2.DropDowns.DropDownList() { DataSource = ViewBag.DropDownData, Query = "new ej.data.Query()", AllowFiltering = true, Fields = new Syncfusion.EJ2.DropDowns.DropDownListFieldSettings() { Value = "Country", Text = "Country" }, ActionComplete = "actionComplete" };
}
{
    <e-grid-column field="ShipCountry" headerText="Ship Country" width="150" editType="dropdownedit" edit="new {@params = DropDownList }"></e-grid-column>
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

