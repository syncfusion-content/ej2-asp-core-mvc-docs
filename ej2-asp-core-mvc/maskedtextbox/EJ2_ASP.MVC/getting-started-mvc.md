---
layout: post
title: Getting Started with ##Platform_Name## Maskedtextbox Component
description: Checkout and learn about getting started with ##Platform_Name## Maskedtextbox component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to include a simple MaskedTextBox in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started/) page for introduction part part of the system requirements and configure the common specifications.

## Initialize MaskedTextBox control to the Application

MaskedTextBox control can be rendered by using the `EJS().MaskedTextBox()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the MaskedTextBox.

The following example shows a basic MaskedTextBox control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/gettingstarted/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gettingstarted.cs" %}
{% include code-snippet/maskedtextbox/gettingstarted/gettingstarted.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/gettingstarted/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gettingstarted.cs" %}
{% include code-snippet/maskedtextbox/gettingstarted/gettingstarted.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Running the above code will display the basic MaskedTextBox on the browser.

## Set the mask

You can set the mask to the MaskedTextBox to validate the user input by using the [mask](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.MaskedTextBox.html#Syncfusion_EJ2_Inputs_MaskedTextBox_Mask) property. To know more about
the usage of mask and configuration, refer to this [link](./mask-configuration/).

The following example demonstrates the usage of mask element `0` that allows any single digit from `0` to `9`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/mask/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mask.cs" %}
{% include code-snippet/maskedtextbox/mask/mask.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maskedtextbox/mask/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mask.cs" %}
{% include code-snippet/maskedtextbox/mask/mask.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![MaskedTextBox Sample](./images/mask.png)

## See Also

* [How to perform custom validation using FormValidator](./how-to/perform-custom-validation-using-form-validator/)
* [How to customize the UI appearance of the control](./how-to/customize-the-ui-appearance-of-the-control/)
* [How to set cursor position while focus on the input textbox](./how-to/set-cursor-position-while-focus-on-the-input-textbox/)
* [How to display numeric keypad when focus on mobile devices](./how-to/display-numeric-keypad-when-focus-on-mobile-devices/)
