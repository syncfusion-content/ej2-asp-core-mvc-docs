---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Controls of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Controls
publishingplatform: ##Platform_Name##
documentation: ug
---


# List of controls

In-place Editor renders various controls based on the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Type) property and it have built-in and injectable controls. To use injectable controls, inject the required modules into `InPlaceEditor`. By default, the `type` property set to `Text` and render the `TextBox`.

The following table explains Injectable components module name and built-in components and their types.

| **Injectable Components** | **Built in Components** |
|-----------------------|---------------------|
| [AutoComplete](../auto-complete/)  (`AutoComplete`)        | [TextBox](../textbox/)  (`Text`)             |
| [ComboBox](../combo-box/)  (`ComboBox`)              | [DatePicker](../datepicker/)  (`Date`)        |
| [MultiSelect](../multi-select/)   (`MultiSelect`)        | [DateTimePicker](../datetimepicker/)   (`DateTime`)     |
| [TimePicker](../timepicker/)   (`Time`)         | [DropDownList](../drop-down-list/)  (`DropDownList`)      |
| [DateRangePicker](../daterangepicker/)   (`DateRange`)       | [MaskedTextBox](../maskedtextbox/)   (`Mask`)      |
| [Slider](../slider/)   (`Slider`)             | [NumericTextBox](../numerictextbox/)   (`Numeric`)    |
| [Rte](../rich-text-editor/)     (`RTE`)              |                     |
| [ColorPicker](../color-picker/)    (`Color`)       |                     |

In the following sample, built-in and injectable based In-place Editor controls are rendered.

{% aspTab template="in-place-editor/controls", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![controls](./images/controls.PNG)

## Model configuration

Control properties and events can be customized using the In-place Editor [`model`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Model) property.

In the following code, the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Type) defined as the `Date` and `DatePicker` properties are configured through `model` property to customize the `DatePicker` control at In-place Editor.

{% aspTab template="in-place-editor/model", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [Disable the editor](./how-to/disable-edit-mode/)
* [Animate the editor during popup mode](./how-to/custom-animation/)
