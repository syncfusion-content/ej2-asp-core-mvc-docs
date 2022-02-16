---
layout: post
title: Getting Started with ##Platform_Name## Combo Box Component
description: Checkout and learn about getting started with ##Platform_Name## Combo Box component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

This section briefly explains how to include simple ComboBox control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

## Initialize ComboBox control to the Application

ComboBox control can be rendered by using the `EJS().ComboBox()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the ComboBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/combobox/getting-started/default/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/combobox/getting-started/default/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Binding data source

After initializing, populate the ComboBox with data using the [dataSource](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~DataSource.html) property.
Here, an array of string values is passed to the ComboBox component.

The following example illustrates the output in your browser.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/combobox/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/combobox/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom values

The ComboBox allows the user to give input as custom value which is not required to present in predefined
set of values. By default, this support is enabled by [allowCustom](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~AllowCustom.html)
 property. In this case, both text field and value field considered as same.
The custom value will be sent to post back handler when a form is about to be submitted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/getting-started/customvalue/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customvalue.cs" %}
{% include code-snippet/combobox/getting-started/customvalue/customvalue.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/getting-started/customvalue/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customvalue.cs" %}
{% include code-snippet/combobox/getting-started/customvalue/customvalue.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Configure the popup list

By default, the width of the popup list automatically adjusts according to the ComboBox input element's width, and the height of the popup list has '300px'.

The height and width of the popup list can also be customized using the
[popupHeight](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~PopupHeight.html) and [popupWidth](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~PopupWidth.html) properties
respectively.

In the following sample, popup list's width and height are configured.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/getting-started/suggestionlist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Suggestionlist.cs" %}
{% include code-snippet/combobox/getting-started/suggestionlist/suggestionlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/getting-started/suggestionlist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Suggestionlist.cs" %}
{% include code-snippet/combobox/getting-started/suggestionlist/suggestionlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to bind the data](./data-binding/)
