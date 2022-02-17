---
layout: post
title: Getting Started with ##Platform_Name## Numerictextbox Component
description: Checkout and learn about getting started with ##Platform_Name## Numerictextbox component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to include a simple NumericTextBox in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started/) page for introduction part part of the system requirements and configure the common specifications.

## Initialize NumericTextBox control to the Application

NumericTextBox control can be rendered by using the `ejs-numerictextbox` tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the NumericTextBox.

The following example shows a basic NumericTextBox control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/getting-started/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% include code-snippet/numeric-textbox/getting-started/getting-started/demo.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/getting-started/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% include code-snippet/numeric-textbox/getting-started/getting-started/demo.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Running the above code will display the basic NumericTextBox on the browser.

Output be like the below.

![NumericTextBox Sample](./images/gettingStarted.png)

## Range validation

You can set the minimum and maximum range of values in the NumericTextBox using the [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Min) and
[max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Max) properties, so the numeric value should be in the min and max range.

The validation behavior depends on the [strictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_StrictMode) property.

The below example demonstrates range validation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/getting-started/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/numeric-textbox/getting-started/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/getting-started/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/numeric-textbox/getting-started/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Formatting the value

User can set the format of the NumericTextBox control using [format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Format)
property. The value will be displayed in the specified format, when the control is in focused out state. For more information about
formatting the value, refer to this [link](./formats/).

The below example demonstrates format the value by using currency format value `c2`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/getting-started/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/numeric-textbox/getting-started/format/format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/getting-started/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% include code-snippet/numeric-textbox/getting-started/format/format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](./images/format.png)

## Precision of numbers

You can restrict the number of decimals to be entered in the NumericTextBox by using the [decimals](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Decimals)
and [validateDecimalOnType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_ValidateDecimalOnType) properties.
So, you can't enter the number whose precision is greater than the mentioned decimals.

* If `validateDecimalOnType` is false, number of decimals will not be restricted.
Else, number of decimals will be restricted while typing in the NumericTextBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/getting-started/precision/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Precision.cs" %}
{% include code-snippet/numeric-textbox/getting-started/precision/precision.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/getting-started/precision/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Precision.cs" %}
{% include code-snippet/numeric-textbox/getting-started/precision/precision.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](./images/precision.png)

## See Also

* [How to perform custom validation using FormValidator](./how-to/perform-custom-validation-using-form-validator/)
* [How to customize the UI appearance of the control](./how-to/customize-the-ui-appearance-of-the-control/)
* [How to customize the spin button’s up and down arrow](./how-to/customize-the-spin-buttons-up-and-down-arrow/)
* [How to customize the step value and hide spin buttons](./how-to/customize-the-step-value-and-hide-spin-buttons/)
* [How to prevent nullable input in NumericTextBox](./how-to/prevent-nullable-input-in-numerictextbox/)
* [How to maintain trailing zeros in NumericTextBox](./how-to/maintain-trailing-zeros-in-numerictextbox/)
