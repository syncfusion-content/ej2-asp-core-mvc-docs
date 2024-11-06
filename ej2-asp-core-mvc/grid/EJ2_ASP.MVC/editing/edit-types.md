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

![Customize textbox edit type](../images/editing/textbox-edit-type.png)

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

![Customize numeric textbox edit type](../images/editing/numeric-textbox-edit-type.png)

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

![Customize decimal points in numeric textbox](../images/editing/numeric-textbox-decimal-values.png)

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
{% highlight c# tabtitle="Dropdownlist-params.cs" %}
{% include code-snippet/grid/edit/dropdown-edit-params/dropdown-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize dropdown edit type](../images/editing/dropdown-edit-type.png)

### Provide custom data source for DropDownList component

In Syncfusion's Grid component, you have an option to provide a custom data source for the `DropDownList` component in the edit form. This feature allows you to define a specific set of values for the DropDownList.

To achieve this, you can utilize the `Columns->Edit->Params` property. This property allows you to define the edit params for the column within the grid.

When setting a new data source using the edit params, you need to specify a new [Query](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.dropdowns.dropdownlist.html#Syncfusion_EJ2_DropDowns_DropDownList_Query) property for the DropDownList. The `Query` property allows you to define custom queries for data retrieval and filtering.

In the below demo, DropDownList is rendered with custom data source for the **ShipCountry** column :

### Apply filtering for DropDownList component

The Syncfusion Grid component provides filtering for the DropDownList within the edit form. This feature allows to select options from a predefined list and easily search for specific items using the built-in filtering feature.  

To enable filtering, set the [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.dropdowns.dropdownlist.html#Syncfusion_EJ2_DropDowns_DropDownList_AllowFiltering) property to **true** within the edit params. This will enable the filtering feature in the DropDownList.

In the following demo, filtering is enabled for the **ShipCountry** column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-filter-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filter-dropdownlist.cs" %}
{% include code-snippet/grid/edit/dropdown-filter-edit/filter.cs %}
{% endhighlight %}
{% endtabs %}

![Customize dropdown edit type](../images/editing/filtering-for-dropdown.gif)

### Open popup while focusing in the edit cell

You can open the dropdown edit popup with a single click by focusing the dropdown element. This feature allows you to quickly access and interact with the dropdown options without the need for an additional click.

To achieve this, you can utilize the `showPopup` method provided by the EJ2 DropDownList component. This method can be invoked within the [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event of the Grid, which triggers when an action, such as editing, is completed. By calling the `showPopup` method in this event, you can open the popup for the dropdown edit.

To ensure that the dropdown column is the clicked edit target, you need to set a global flag variable in the **mouseup** event along with [Load](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Load) event. This flag variable will be used to determine if the clicked element corresponds to the dropdown column.

The following sample demonstrates how to open the popup when focusing on the edit cell using the `ActionComplete` and `Load` events:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-popup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popup-dropdownlist.cs" %}
{% include code-snippet/grid/edit/dropdown-popup/dropdown-popup.cs %}
{% endhighlight %}
{% endtabs %}

![Customize dropdown edit type](../images/editing/dropdown-popup.gif)

## Customize CheckBox component of booleanedit type 

You can customize the CheckBox component in Grid edit form using its property. This customization allows you to configure various properties of the CheckBox, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `Columns->Edit->Params` property.

Component| Edit Type |Description |Example Customized edit params
-----|-----|-----|----|
[CheckBox](../../check-box)| booleanedit | The `booleanedit` type renders a **CheckBox** component for boolean data type. To customize the CheckBox component, refer to the [CheckBox API documentation](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.buttons.checkbox.html) for detailed information on available properties. | params: { checked: true}

The following sample code demonstrates the customization applied to CheckBox component of **Verified** Grid column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/checkbox-edit-params/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Check-box-params.cs" %}
{% include code-snippet/grid/edit/checkbox-edit-params/checkbox-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize check box edit type](../images/editing/dropdown-edit-type.png)

## Customize DatePicker component of datepickeredit type 

You can customize the DatePicker component in Grid edit form using its property. This customization allows you to configure various properties of the DatePicker, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `Columns->Edit->Params` property.

Component| Edit Type |Description|Example Customized edit params
-----|-----|-----|----|
[DatePicker](../../datepicker)| datepickeredit | The `datepickeredit` type renders a **DatePicker** component for date data type columns. To customize the DatePicker component, refer to the [DatePicker API documentation](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.calendars.datepicker.html) for detailed information on available properties. | params: { format:'dd.MM.yyyy' }
 
The following sample code demonstrates the customization applied to DatePicker component of **OrderDate** Grid column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/datepicker-edit-params/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Date-picker-params.cs" %}
{% include code-snippet/grid/edit/datepicker-edit-params/datepicker-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize date picker edit type](../images/editing/datepicker-edit-type.png)

## Customize DateTimePicker component of datetimepickeredit type 

You can customize the DateTimePicker component in Grid edit form using its property. This customization allows you to configure various properties of the DateTimePicker, tailoring its behavior and appearance to match your specific requirements within the Grid. The behavior of the editor component can be fine-tuned through the `Columns->Edit->Params` property.

Component|Edit Type |Description |Example Customized edit params
-----|-----|-----|----|
[DateTimePicker](../../datetimepicker)| datetimepickeredit | The `datetimepickeredit` type renders a **DateTimePicker** component for date time data type columns. You can customize the DateTimePicker component, refer to the [DateTimePicker API documentation](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.calendars.datetimepicker.html) for detailed information on available properties. | params: { value: new Date() }
 
The following sample code demonstrates the customization applied to DatePicker component of **OrderDate** Grid column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/date-time-picker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Check-box-params.cs" %}
{% include code-snippet/grid/edit/date-time-picker/date-time-params.cs %}
{% endhighlight %}
{% endtabs %}

![Customize date time picker edit type](../images/editing/date-time-picker-edit.png)

## Access editor components using instance

Accessing editor components in the Syncfusion Grid allows you to interact with the editor instances associated with cells during editing or adding actions. This feature is especially useful when you need to perform custom actions, retrieve data from the Editor, or manipulate its properties during editing or adding operations in the Grid.

To access the component instance from the component element, you can use the **ej2_instances** property. This property provides access to the instance of the editor component associated with a cell.

In the below demo, you can access the editor component instance while adding or editing actions in the [ActionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/editor-component/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Editor.cs" %}
{% include code-snippet/grid/edit/editor-component/editor.cs %}
{% endhighlight %}
{% endtabs %}

![Customize editor component](../images/editing/editor-component.png)

## Render custom cell editors using external function

The Syncfusion Grid provides the ability to render custom cell editors, allowing you to add custom controls to specific columns in your grid using the cell edit template feature. This feature is useful when you need to edit cell values using custom input elements or controls.

To utilize the custom cell editor template feature, you need to implement the following functions:

* **create** - It is used to create the element at the time of initialization.

* **write** - It is used to create custom control or assign default value at the time of editing.

* **read** - It is used to read the value from the control at the time of save.
          
* **destroy** - It is used to destroy the control.

### Render textArea in edit form 

The Syncfusion Grid allows you to render a textArea within the Grid's edit form for a specific column. This feature is especially valuable when you need to edit and display multi-line text content, providing an efficient way to manage extensive text data within the Grid's columns.

To render a textArea in the edit form, you need to define a cell edit template for the column using `Edit` property. The `Edit` property specifies the cell edit template that used  as an editor for a particular column.

> When using a text area, please use **Shift+Enter** to move to the next line. By default, pressing **Enter** will trigger a record update while you are in edit mode.

The following example demonstrates how to render a textArea control in the **ShipAddress** column of the Syncfusion Grid. The `valueAccessor` property is utilized to split the text into multiple lines within the grid column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/textarea-cell-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-area-edit.cs" %}
{% include code-snippet/grid/edit/textarea-cell-edit/textarea.cs %}
{% endhighlight %}
{% endtabs %}

![Render text area component](../images/editing/render-textarea-component.png)

**Prevent the enter key functionality in multiline textbox while editing** 

While editing a particular row in normal or dialog edit mode, pressing the **ENTER** key will save the changes made in the specific cell or edit form. Similarly, pressing the **ENTER** key while performing editing with the multiline textbox will save the changes.  However, in a multiline textbox, it is often desired that pressing the **ENTER** key adds a new line break in the text content, rather than triggering the save action.

To achieve this behavior, you can utilize the `stopPropagation` method along with the [Focus](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.inputs.textbox.html#Syncfusion_EJ2_Inputs_TextBox_Focus) event of the textBox control. This prevents the default behavior of the **ENTER** key, allowing you to manually handle the newline behavior.

The following example demonstrates how to prevent the enter key functionality in multiline textbox during editing by utilizing the `Focus` event:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/textarea-enter-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-area-edit.cs" %}
{% include code-snippet/grid/edit/textarea-enter-edit/textarea.cs %}
{% endhighlight %}
{% endtabs %}

![Prevent enter key functionality](../images/editing/customize-enter-key.gif)

### Render MaskedTextBox control in edit form 

The Syncfusion Grid allows you to render a MaskedTextBox control within the Grid's edit form for a specific column. This feature is especially useful when you need to provide masked input fields that require a specific format, such as phone numbers or postal codes.

To render a MaskedTextBox control in the edit form, you need to define a cell edit template for the column using `Edit` property. The `Edit` property specifies the cell edit template that used  as an editor for a particular column.

Here's an example of how to render a MaskedTextBox control in the **CustomerNumber** column of the Syncfusion Grid.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/masked-textbox-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-area-edit.cs" %}
{% include code-snippet/grid/edit/masked-textbox-edit/textarea.cs %}
{% endhighlight %}
{% endtabs %}

### Render DropDownList control in edit form 

The Syncfusion Grid allows you to render a DropDownList control within the Grid's edit form for a specific column. This feature is valuable when you need to provide a convenient way to select options from a predefined list while editing data in the Grid's edit form.

To render a DropDownList control in the edit form,  you need to define a cell edit template for the column using `Edit` property. The `Edit` property specifies the cell edit template that used  as an editor for a particular column.

The following example demonstrates how to render a DropDownList control in the **ShipCountry** column of the Syncfusion Grid.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/drop-down-list-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-area-edit.cs" %}
{% include code-snippet/grid/edit/drop-down-list-edit/dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

![Render drop down list component](../images/editing/render-dropdown-component.png)

### Render images in the DropDownList editor control using the item template 

The Syncfusion Grid allows you to render images in the DropDownList editor conttol. This feature is valuable when you want to display images for each item in the dropdown list of a particular column, enhancing the visual representation of your data.

To render a DropDownList in the edit form, you need to define a cell edit template for the column using `Edit` property. The `Edit` property specifies the cell edit template that used  as an editor for a particular column.

To display an image in the DropDownList editor control, you can utilize the [ItemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ItemTemplate) property. This property allows you to customize the content of each item in the dropdown list.

The following example demonstrates how to render images in the DropDownList editor control using the `ItemTemplate` within the **EmployeeName** column of the Syncfusion Grid. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dropdown-with-image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-area-edit.cs" %}
{% include code-snippet/grid/edit/dropdown-with-image/dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

![Render drop down list component with image](../images/editing/dropdown-with-image.png)

### Render Multiple columns in DropDownList control  

The Syncfusion Grid allows you to render a DropDownList control within the Grid's edit form for a specific column. This feature is particularly useful when you want to display more detailed information for each item in the dropdown list during editing a specific column.

To render a DropDownList in the edit form, you need to define a cell edit template for the column using `Edit` property. The `Edit` property specifies the cell edit template that used  as an editor for a particular column.

The DropDownList has been provided with several options to customize each list item, group title, selected value, header, and footer element. By default, list items can be rendered as a single column in the DropDownList control. Instead of this, multiple columns can be rendered. This can be achieved by using the [HeaderTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_HeaderTemplate) and [ItemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ItemTemplate) properties of the DropDownList control.

The following example demonstrates how to render a DropDownList control with multiple columns within in the **ShipCountry** column.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/multiple-column-dropdown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="drop-down-list-edit.cs" %}
{% include code-snippet/grid/edit/multiple-column-dropdown/dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

![Render multiple columns in drop down list component](../images/editing/multiple-column-dropdown.png)

### Render ComboBox control in edit form 

The Syncfusion Grid allows you to render a ComboBox control within the Grid's edit form for a specific column. This feature is especially valuable when you need to provide a drop-down selection with auto-suggestions for data entry.

To render a comboBox control in the edit form, you need to define a cell edit template for the column using `Edit` property. The `Edit` property specifies the cell edit template that used  as an editor for a particular column.

The following example demonstrates how to render a ComboBox control in the **ShipCountry** column of the Syncfusion Grid. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/combo-box/razor %}
{% endhighlight %}
{% highlight c# tabtitle="combo-box.cs" %}
{% include code-snippet/grid/edit/combo-box/combo-box.cs %}
{% endhighlight %}
{% endtabs %}

![Render combo box component](../images/editing/render-combobox-component.png)

### Render TimePicker control in edit form 

The Syncfusion Grid allows you to render a TimePicker control within the Grid's edit form for a specific column. This feature is especially valuable when you need to provide a time input, such as appointment times, event schedules, or any other time-related data for editing in the Grid.

To render a TimePicker control in the edit form, you need to define a cell edit template for the column using `Edit` property. The `Edit` property specifies the cell edit template that used  as an editor for a particular column.

The following example demonstrates how to render a TimePicker control in the **OrderDate** column of the Syncfusion Grid.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/timepicker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TimePicker.cs" %}
{% include code-snippet/grid/edit/timepicker/timepicker.cs %}
{% endhighlight %}
{% endtabs %}

![Render timepicker component](../images/editing/render-timepicker-component.png)


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

