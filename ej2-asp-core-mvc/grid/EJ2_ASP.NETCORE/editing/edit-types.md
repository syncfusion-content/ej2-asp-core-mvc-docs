---
layout: post
title: ##Platform_Name## Grid Edit Types | Syncfusion
description: Learn how to configure edit types in ##Platform_Name## Data Grid, choose appropriate cell editors, customize editing behavior, and manage column editing efficiently.
platform: ej2-asp-core-mvc
control: Edit Types
publishingplatform: ##Platform_Name##
documentation: ug
---

# Edit Types in ASP.NET Core Data Grid

The Data Grid supports built-in edit types and custom editors for editing data within grid cells. It provides editor interfaces for different data types and supports custom editing experiences to meet specific application requirements.

## Built-in cell editors

The Data Grid includes built-in cell editors that provide an appropriate editing interface based on the column data type. For example, a date column can use a `DatePicker` editor, while a numeric column can use a `NumericTextBox` editor. This helps ensure that data is entered in a format that matches the column's data type.

Cell editors can be enabled by setting the `editType` property in the grid column definition. Supported editors include `TextBox`, `NumericTextBox`, `DatePicker`, `DateTimePicker`, `CheckBox`, and `DropDownList` editors, enabling data entry and validation that align with the column's requirements. The available default edit types are as follows:

The available default edit types are as follows:

Component | Edit Type value | Description
----|-----|-----
[TextBox](../../textbox/getting-started) |`stringedit`|  Renders a `TextBox` component for string data type columns. 
[NumericTextBox](../../numerictextbox/getting-started) |`numericedit`| Renders a `NumericTextBox` component for integers, double, float, short, byte, long, long double, and decimal data types.
[DropDownList](../../drop-down-list/getting-started) |`dropdownedit`| Renders a `DropDownList` component for string data type columns with predefined options.
[CheckBox](../../check-box/getting-started) |`booleanedit`| Renders a `CheckBox` component for boolean data type columns.
[DatePicker](../../datepicker/getting-started) |`datepickeredit`| Renders a `DatePicker` component for date data type columns.
[DateTimePicker](../../datetimepicker/getting-started) |`datetimepickeredit`| Renders a `DateTimePicker` component for date-time data type columns.

The following example demonstrates defining the `editType` for grid columns:

```html
    <e-grid-column field="CustomerName" headerText="Customer Name" editType="stringedit"></e-grid-column>
    <e-grid-column field="Frieght" headerText="Frieght" editType="numericedit'"></e-grid-column>
    <e-grid-column field="ShipCountry" headerText="Ship Country" editType="dropdownedit"></e-grid-column>
    <e-grid-column field="OrderDate" headerText="Order Date" editType="datepickeredit"></e-grid-column>
    <e-grid-column field="OrderTime" headerText="Order Time" editType="datetimepickeredit"></e-grid-column>
    <e-grid-column field="Verified" headerText="Verified" editType="booleanedit"></e-grid-column>
```

> When the edit type is not defined for a column, the grid defaults to the `stringedit` edit type and displays a `TextBox` editor for editing values.

## Customize built-in TextBox editor

The TextBox editor can be customized by configuring its component properties through the `columns.edit.params` option. This allows TextBox features, behavior, and appearance to be customized during editing.

Component|Edit Type |Description|Example Customized edit params
-----|---|-----|-----|
[TextBox](../../textbox/getting-started) |stringedit| The `stringedit` type renders a TextBox component for string data type columns. To customize the `TextBox` component, refer to the [TextBox API documentation](../../api/textbox) for detailed information on available properties | params: { showClearButton : true}

The following sample code demonstrates the customization applied to `TextBox` component of "Customer ID" grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/textbox-edit-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Textbox-params.cs" %}
{% include code-snippet/grid/edit/textbox-edit-params/textbox-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize textbox edit type](../images/editing/textbox-edit-type.png)

## Customize built-in NumericTextBox editor 

The `NumericTextBox` editor can be customized by configuring its component properties through the grid `columns->edit->params` property. This allows `NumericTextBox` features, behavior, and appearance to be customized during editing

Component| Edit Type |Description |Example Customized edit params
-----|-----|-----|----|
[NumericTextBox](../../numerictextbox/getting-started)|numericedit| The `numericedit` type renders a NumericTextBox component for integer, double, float, short, byte, long, long double, and decimal data type columns. To customize the `NumericTextBox` component, refer to the [NumericTextBox API documentation](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.numerictextbox.html) for detailed information on available properties. | params: { decimals: 2, value: 5 }

The following sample code demonstrates the customization applied to `NumericTextBox` component of "Freight" grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/numeric-edit-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Numeric-textbox-params.cs" %}
{% include code-snippet/grid/edit/numeric-edit-params/numeric-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize numeric textbox edit type](../images/editing/numeric-textbox-edit-type.png)

### Restrict decimal input in NumericTextBox while editing

`NumericTextBox` allows decimal input by default. To restrict entries to whole numbers, use the [validateDecimalOnType](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.numerictextbox.html#Syncfusion_EJ2_Inputs_NumericTextBox_ValidateDecimalOnType) (set to `true` to block decimals) and [decimals](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.numerictextbox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Decimals) properties.

In this demo, while editing a row, decimal values are restricted when typing into the `NumericTextBox` of the "Freight" column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/prevent-decimal-point/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Prevent-decimal-point.cs" %}
{% include code-snippet/grid/edit/prevent-decimal-point/decimal-value.cs %}
{% endhighlight %}
{% endtabs %}

![Customize decimal points in numeric textbox](../images/editing/numeric-textbox-decimal-values.png)

## Customize built-in DropDownList editor 

Customize the `DropDownList` editor via `columns->edit->params`. This allows configuration of DropDownList properties for string columns.

Component | Edit Type | Description | Example edit params
-----|-----|-----|----|
[DropDownList](../../drop-down-list/getting-started) | dropdownedit | The `dropdownedit` type renders a DropDownList component for string data type columns. To customize the DropDownList component, refer to the [DropDownList API documentation](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdownlist.html) for detailed information on available properties.  | params: { value: 'Germany' }

The following sample code demonstrates the customization applied to `DropDownList` component of "Ship City" grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-edit-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dropdownlist-params.cs" %}
{% include code-snippet/grid/edit/dropdown-edit-params/dropdown-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize dropdown edit type](../images/editing/dropdown-edit-type.png)

### Bind external data to DropDownList

In the Data Grid component, a custom data source can be provided for the [DropDownList](https://ej2.syncfusion.com/aspnetcore/documentation/drop-down-list/getting-started) component in the edit form. This feature allows defining a specific set of values for the `DropDownList`.

To achieve this, the `columns->edit->params` property can be utilized. This property allows defining the edit params for the column within the grid.

When setting a new data source using the edit params, a new [query](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_Query) property must be specified for the DropDownList. The query property enables defining custom queries for data retrieval and filtering.

In this demo, the `DropDownList` is rendered with a custom data source for the "Ship Country" column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/custom-data-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dropdownlist-params.cs" %}
{% include code-snippet/grid/edit/custom-data-params/dropdown-params.cs %}
{% endhighlight %}
{% endtabs %}

![Provide custom data source for DropDownList component](../images/editing/dropdown-edit-type.png)

### DropDownList editor with filter support

The Data Grid component provides filtering for the `DropDownList` within the edit form. This feature enables selection of options from a predefined list and easier search for specific items using the built-in filtering feature.  

Enable filtering by setting the [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdownlist.html#Syncfusion_EJ2_DropDowns_DropDownList_AllowFiltering) property to `true` within the edit params. This enables the filtering feature in the `DropDownList`.

In the following demo, filtering is enabled for the "Ship Country" column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-filter-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filter-dropdownlist.cs" %}
{% include code-snippet/grid/edit/dropdown-filter-edit/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Customize dropdown edit type](../images/editing/filtering-for-dropdown.gif)

### DropDownList popup on focus

Open the dropdown edit popup with a single click by focusing the dropdown element. This feature enables quick access and interaction with the dropdown options without the need for an additional click.

To achieve this, utilize the `showPopup` method provided by the EJ2 DropDownList component. This method can be invoked within the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event of the grid, which triggers when an action, such as editing, is completed. By calling the `showPopup` method in this event, open the popup for the dropdown edit.

To ensure that the dropdown column is the clicked edit target, set a global flag variable in the `mouseup` event along with `load` event. This flag variable determines if the clicked element corresponds to the dropdown column.

The following example demonstrates opening the popup when focusing on the edit cell by handling the `actionComplete` and `load` events in the grid.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-popup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popup-dropdownlist.cs" %}
{% include code-snippet/grid/edit/dropdown-popup/dropdown-popup.cs %}
{% endhighlight %}
{% endtabs %}

![Customize dropdown edit type](../images/editing/dropdown-popup.png)

## Customize built-in CheckBox editor

Customize the `CheckBox` component using the `columns->edit->params` property.

Component | Edit Type | Description | Example edit params
-----|-----|-----|----|
[CheckBox](../../check-box/getting-started)| booleanedit | The `booleanedit` type renders a `CheckBox` component for boolean data type. To customize the CheckBox component, refer to the [CheckBox API documentation](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.buttons.checkbox.html) for detailed information on available properties. | params: { checked: true }

The following sample code demonstrates the customization applied to `CheckBox` component of "Verified" grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/checkbox-edit-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Check-box-params.cs" %}
{% include code-snippet/grid/edit/checkbox-edit-params/checkbox-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize check box edit type](../images/editing/checkbox-edit-type.png)

## Customize built-in DatePicker editor

Enhance the [DatePicker](../../datepicker/getting-started) component in grid edit form by customizing its properties. This enables configuration of various DatePicker features, tailoring its behavior and appearance to match specific requirements within the grid. Fine-tune the editor component behavior through the columns->edit->params property for date selection behavior.

Component | Edit Type | Description | Example edit params
-----|-----|-----|----|
[DatePicker](../../datepicker/getting-started)| datepickeredit | The `datepickeredit` type renders a `DatePicker` component for date data type columns. To customize the DatePicker component, refer to the [DatePicker API documentation](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.calendars.datepicker.html) for detailed information on available properties. | params: { format:'dd.MM.yyyy' }
 
The following sample code demonstrates the customization applied to `DatePicker` component of "Order Date" grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/datepicker-edit-params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Date-picker-params.cs" %}
{% include code-snippet/grid/edit/datepicker-edit-params/datepicker-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize date picker edit type](../images/editing/datepicker-edit-type.png)

### Restrict minimum selectable date in DatePicker

Set a minimum selectable date dynamically in the DatePicker editor by configuring the minimum property in `edit` params. This prevents selection of dates prior to a specified value.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/hide-date/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="hide-date.cs" %}
{% include code-snippet/grid/edit/hide-date/hide-date.cs %}
{% endhighlight %}
{% endtabs %}

![Disable the date value](../images/editing/hide-date.png)

## Customize built-in DateTimePicker editor 

Enhance the `DateTimePicker` component in grid edit form by customizing its properties. This enables configuration of various DateTimePicker features, tailoring its behavior and appearance to match specific requirements within the grid. Fine-tune the editor component behavior through the `columns->edit->params` property for date-time selection behavior.

Component | Edit Type | Description | Example edit params
-----|-----|-----|----|
[DateTimePicker](../../datetimepicker/getting-started) | datetimepickeredit |  The `datetimepickeredit` type renders a `DateTimePicker` component for date time data type columns. Customize the DateTimePicker component by referring to the [DateTimePicker API documentation](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.calendars.datetimepicker.html) for detailed information on available properties. | params: { value: new Date() }
 
The following sample code demonstrates the customization applied to DateTimePicker component of "Order Date" grid column:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/date-time-picker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Check-box-params.cs" %}
{% include code-snippet/grid/edit/date-time-picker/date-time-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize date time picker edit type](../images/editing/date-time-picker-edit.png)


## Render custom editor components

The Data Grid provides flexible support for rendering custom cell editors, enabling the addition of specialized custom components to specific columns. This is useful for editing cell values using custom input elements or controls tailored to specific data types or workflows.

To utilize the custom cell editor template feature, implement these four essential functions:

| Function | Purpose | When Triggered |
|----------|---------|--------|
| `create` | Create the DOM element or component container | During component initialization |
| `write` | Create the custom component and assign default values | When editing begins on the cell |
| `read` | Extract and return the edited value from the component | When saving changes to the cell |
| `destroy` | Clean up and remove the component | When exiting edit mode or closing the editor |

### Render TextArea in edit form 

The Data Grid allows rendering a `TextArea` within the grid's edit form for a specific column. This feature is especially valuable when there is a need to edit and display multi-line text content, providing an efficient way to manage extensive text data within the grid's columns.

To render a `TextArea` in the edit form, define a cell edit template for the column using the `edit` property.

> When using a text area, please use <kbd>Shift+Enter</kbd> to move to the next line. By default, pressing <kbd>Enter</kbd> will trigger a record update while in edit mode.

The following example demonstrates rendering a `TextArea` component in the "ShipAddress" column of the grid. The `valueAccessor` property is used to split the text into multiple lines within the grid column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/textarea-cell-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-area-edit.cs" %}
{% include code-snippet/grid/edit/textarea-cell-edit/textarea.cs %}
{% endhighlight %}
{% endtabs %}

![Render text area component](../images/editing/render-textarea-component.png)

**Prevent Enter key from saving edits in a multiline textbox**

Override the default Enter key behavior in multiline textboxes by using the `stopPropagation` method in the textbox's [focus](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.textbox.html#Syncfusion_EJ2_Inputs_TextBox_Focus) event, ensuring Enter inserts a new line instead of saving the edit.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/textarea-enter-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-area-edit.cs" %}
{% include code-snippet/grid/edit/textarea-enter-edit/textarea.cs %}
{% endhighlight %}
{% endtabs %}

![Prevent enter key functionality](../images/editing/customize-enter-key.gif)

### Render AutoComplete in edit form 

The Data Grid allows rendering an `AutoComplete` component within the grid's edit form for a specific column. This feature is especially valuable when there is a need to provide a dropdown like auto suggestion and input assistance for data entry in the grid's columns.

To render an `AutoComplete` in the edit form, define a cell edit template for the column using the `edit` property.

The following example demonstrates rendering an `AutoComplete` component in the "Customer ID" column of the grid. The `actionBegin` event is handled to update the edited value in the grid when the save button is clicked.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/autocomplete/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoComplete.cs" %}
{% include code-snippet/grid/edit/autocomplete/autocomplete.cs %}
{% endhighlight %}
{% endtabs %}

![Render auto complete component](../images/editing/render-auto-complete.png)

### Render MaskedTextBox in the edit form

The Data Grid allows rendering an `MaskedTextBox` component within the grid's edit form for a specific column. This feature is especially useful when there is a need to provide masked input fields that require a specific format, such as phone numbers or postal codes.

To render a `MaskedTextBox` in the edit form, define a cell edit template for the column using the `edit` property.

Here's an example to render a `MaskedTextBox` component in the "Customer Number" column of the Syncfusion Grid. The `actionBegin` event is handled to update the edited value in the grid when the save button is clicked:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/masked-textbox-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-area-edit.cs" %}
{% include code-snippet/grid/edit/masked-textbox-edit/textarea.cs %}
{% endhighlight %}
{% endtabs %}

![Render masked text box component](../images/editing/masked-textbox-component.png)

### Render DropDownList in edit form 

The Data Grid allows rendering a `DropDownList` component within the Grid's edit form for a specific column. This feature is valuable when there is a need to provide a convenient way to select options from a predefined list while editing data in the grid's edit form.

To render a `DropDownList` in the edit form, define a cell edit template for the column using the `edit` property.

The following example demonstrates rendering a `DropDownList` component in the "Ship Country" column of the grid. The `actionBegin` event is handled to update the edited value in the grid when the save button is clicked.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/drop-down-list-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="drop-down-list-edit.cs" %}
{% include code-snippet/grid/edit/drop-down-list-edit/dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

![Render drop down list component](../images/editing/render-dropdown-component.png)

### Render images in the DropDownList using item template

The Data Grid allows rendering images in the `DropDownList` editor component. This feature is valuable when there is a need to display images for each item in the dropdown list of a particular column, enhancing the visual representation of the data.

To display an image in the DropDownList editor component, the  [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ItemTemplate) property can be utilized. This property allows customization of the content of each item in the dropdown list.

To render images in a `DropDownList` edit form, define a cell edit template for the column using the `edit` property.

The following example demonstrates rendering images in the DropDownList editor component using the `itemTemplate` within the "Employee Name" column of the grid. The `actionBegin` event is handled to update the edited value in the grid when the save button is clicked.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-with-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="drop-down-list-edit.cs" %}
{% include code-snippet/grid/edit/dropdown-with-image/dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

![Render drop down list component with image](../images/editing/dropdown-with-image.jpeg)

### Render multiple columns in DropDownList 

The Data Grid supports rendering a `DropDownList` component within the Grid's edit form for a specific column. This feature is useful for displaying detailed information for each item in the dropdown list during column editing.

The `DropDownList` has been provided with several options to customize each list item, group title, selected value, header, and footer element. By default, list items can be rendered as a single column in the `DropDownList` component. Instead of this, multiple columns can be rendered. This can be achieved by using the [headerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_HeaderTemplate) and [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ItemTemplate) properties of the `DropDownList` component.

To render multiple columns in a `DropDownList` edit form, define a cell edit template for the column using the `edit` property.

The following example demonstrates rendering a `DropDownList` component with multiple columns within the "Ship Country" column of the grid. The `actionBegin` event is handled to update the edited value in the grid when the save button is clicked.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/multiple-column-dropdown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="drop-down-list-edit.cs" %}
{% include code-snippet/grid/edit/multiple-column-dropdown/dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

![Render multiple columns in drop down list component](../images/editing/multiple-column-dropdown.png)

### Render ComboBox in edit form

The Data Grid supports rendering a `ComboBox` component within the Grid's edit form for a specific column. This feature is useful for providing a drop-down selection with auto-suggestions for data entry.

To render a `ComboBox` in the edit form, define a cell edit template for the column using the `edit` property.

The following example demonstrates rendering a `ComboBox` component in the "Ship Country" column of the grid. The `actionBegin` event is handled to update the edited value in the grid when the save button is clicked. 

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/combo-box/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="combo-box.cs" %}
{% include code-snippet/grid/edit/combo-box/combo-box.cs %}
{% endhighlight %}
{% endtabs %}

![Render combo box component](../images/editing/render-combobox-component.png)

### Render TimePicker in edit form 

The Data Grid supports rendering a `TimePicker` component within the grid's edit form for a specific column. This feature is useful for providing a time input, such as appointment times or event schedules, for editing in the grid.

To render a `TimePicker` in the edit form, define a cell edit template for the column using the `edit` property.

The following example demonstrates rendering a `TimePicker` component in the "Order Date" column of the grid. The `actionBegin` event is handled to update the edited value in the grid when the save button is clicked.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/timepicker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TimePicker.cs" %}
{% include code-snippet/grid/edit/timepicker/timepicker.cs %}
{% endhighlight %}
{% endtabs %}

![Render timepicker component](../images/editing/render-timepicker-component.png)

### Render MultiSelect in edit form

The Data Grid supports rendering a `MultiSelect` component within the Grid's edit form, enabling selection of multiple values from a dropdown list when editing a specific column. This feature is useful when multiple selections are required for a column.

To render a `MultiSelect` in the edit form, define a cell edit template for the column using the [edit](../../api/grid/column/#edit) property.

The following example demonstrates rendering a `MultiSelect` component in the "Ship City" column of the grid. The [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event is handled to update the edited value in the grid when the save button is clicked.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/multiselect-dropdown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MultiSelect.cs" %}
{% include code-snippet/grid/edit/multiselect-dropdown/multiselect.cs %}
{% endhighlight %}
{% endtabs %}

![Render multiselect component](../images/editing/render-multiselect-dropdown.jpeg)

### Render RichTextEditor in edit form

The Data Grid allows rendering the `RichTextEditor` component within the edit form. This enables formatting and styling text content using bold, italic, underline, bullet lists, numbered lists, and other formatting options.

Set the [allowTextWrap](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowTextWrap) property of the corresponding grid column to `true`. Enabling this property allows the rich text editor component to adjust its width and wrap text content to fit within the boundaries of the column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/richtext-editor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RTE.cs" %}
{% include code-snippet/grid/edit/richtext-editor/richtext.cs %}
{% endhighlight %}
{% endtabs %}

![Render richtext editor component](../images/editing/render-richtext-editor.jpeg)

### Render Uploader in edit form 

The Data Grid allows rendering an [Uploader](../../uploader/getting-started) component within the grid's edit form. This enables uploading and managing files or images in a specific column during data editing.

To render an `Uploader` in the edit form, define a cell edit template for the column using the [edit](../../api/grid/column/#edit) property.

The following example demonstrates rendering an `Uploader` component in the "Order Image" column of the grid. The [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event is handled to update the edited value in the grid when the save button is clicked.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/edit-upload/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="upload.cs" %}
{% include code-snippet/grid/edit/edit-upload/upload.cs %}
{% endhighlight %}
{% endtabs %}

![Render Upload component in edit form](../images/editing/edit-types-upload.jpeg)

### Render cascading DropDownList in edit form

The Data Grid component supports rendering cascading `DropDownList` editors within the edit form by using the cell edit template feature. This is particularly useful for establishing hierarchical options, such as selecting a country and then filtering states based on the chosen country.

To render cascading `DropDownList` editors in the edit form, define a cell edit template for the column using the `edit` property.

In the below demo, cascading DropDownList rendered for "ShipCountry" and "ShipState" column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/cascading-dropdown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Drop-down.cs" %}
{% include code-snippet/grid/edit/cascading-dropdown/dropdown.cs %}
{% endhighlight %}
{% endtabs %}

![Render cascading DropDownList](../images/editing/cascading-dropdown.gif)

## Access editor controls using instance

Accessing editor components in the Data Grid enables direct interaction with editor instances associated with cells during editing or adding actions. This feature is especially valuable when performing custom actions, retrieving data from the editor, or manipulating its properties during editing or adding operations in the grid.

Access the component instance from the component element using the `ej2_instances` property. This property provides access to the instance of the editor component associated with a cell.

In the below demo, access the editor component instance while adding or editing actions in the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/editor-component/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Editor.cs" %}
{% include code-snippet/grid/edit/editor-component/editor.cs %}
{% endhighlight %}
{% endtabs %}

![Customize editor component](../images/editing/editor-component.png)
