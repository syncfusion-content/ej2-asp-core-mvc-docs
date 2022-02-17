---
layout: post
title: Controls in ##Platform_Name## In Place Editor Component
description: Learn here all about Controls in Syncfusion ##Platform_Name## In Place Editor component and more.
platform: ej2-asp-core-mvc
control: Controls
publishingplatform: ##Platform_Name##
documentation: ug
---


# List of controls

In-place Editor renders various controls based on the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Type) property and it have built-in and injectable controls. To use injectable controls, inject the required modules into `InPlaceEditor`. By default, the `type` property set to `Text` and render the `TextBox`.

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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/controls/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/controls/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/controls/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/controls/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![controls](./images/controls.PNG)

## Model configuration

Control properties and events can be customized using the In-place Editor [`Model`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Model) property.

In the following code, the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Type) defined as the `Date` and `DatePicker` properties are configured through `Model` property to customize the `DatePicker` control at In-place Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/model/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/model/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/model/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/model/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Disable the editor](./how-to/disable-edit-mode/)
* [Animate the editor during popup mode](./how-to/custom-animation/)