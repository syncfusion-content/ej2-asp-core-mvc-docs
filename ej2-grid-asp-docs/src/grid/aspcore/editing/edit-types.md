# Edit Types

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

{% aspTab template="grid/edit/celleditparams", sourceFiles="celleditparams.cs" %}

{% endaspTab %}

> If edit type is not defined in the column, then it will be considered as the **stringedit** type (Textbox component).

### Restrict to type decimal points in a NumericTextBox while editing the numeric column

By default, the number of decimal places will be restricted to two in the NumericTextBox while editing the numeric column. We can restrict to type the decimal points in a NumericTextBox by using the **validateDecimalOnType** and **decimals** properties of NumericTextBox.

In the below demo, while editing the row we have restricted to type the decimal point value in the NumericTextBox of **Freight** column.

{% aspTab template="grid/how-to/prevent-decimal-point", sourceFiles="prevent-decimal-point.cs" %}

{% endaspTab %}

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

{% aspTab template="grid/how-to/dropdown-edit", sourceFiles="edit-dropdownlist.cs" %}

{% endaspTab %}

## Custom editors using template

The cell edit template is used to add a custom component for a particular column by invoking the following functions:

* **create** - It is used to create the element at the time of initialization.

* **write** - It is used to create the custom component or assign default value at the time of editing.

* **read** - It is used to read the value from the component at the time of save.

* **destroy** - It is used to destroy the component.

{% aspTab template="grid/edit/celledittemplate", sourceFiles="celledittemplate.cs" %}

{% endaspTab %}

## Access editor components

You can access the component instance from the component element using the **ej2_instances** property.

In the below demo, you can access the Editor component instance while adding or editing actions in the [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event.

{% aspTab template="grid/how-to/access-editor", sourceFiles="access-editor.cs" %}

{% endaspTab %}