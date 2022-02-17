---
layout: post
title: Getting Started with ##Platform_Name## Auto Complete Component
description: Checkout and learn about getting started with ##Platform_Name## Auto Complete component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

This section briefly explains how to include simple AutoComplete control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

## Initialize AutoComplete control to the Application

AutoComplete control can be rendered by using the `EJS().AutoComplete()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the AutoComplete.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/autocomplete/getting-started/default/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/autocomplete/getting-started/default/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Running the above code will display the basic AutoComplete on the browser.

## Binding data source

After initialization, populate the AutoComplete with data using the
[dataSource](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~DataSource.html) property.
Here, an array of string values is passed to the AutoComplete control.

The following example illustrates the output in your browser.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/autocomplete/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/autocomplete/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom values

The AutoComplete allows the user to give input as custom value which is not required to present in
predefined set of values. By default, this support is enabled by
[allowCustom](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~AllowCustom.html) property.
The custom value will be sent to post back handler when a form
is about to be submitted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/customvalue/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customvalue.cs" %}
{% include code-snippet/autocomplete/getting-started/customvalue/customvalue.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/customvalue/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customvalue.cs" %}
{% include code-snippet/autocomplete/getting-started/customvalue/customvalue.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Configure the suggestion list

By default, suggestion list width automatically adjusts according to the AutoComplete input element's width, and the height of the suggestion list has '300px'.

The height and width of the popup list can also be customized using the
[popupHeight](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~PopupHeight.html) and [popupWidth](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~PopupWidth.html) property respectively.

In the following sample, suggestion list's width and height are configured.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/suggestionlist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Suggestionlist.cs" %}
{% include code-snippet/autocomplete/getting-started/suggestionlist/suggestionlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/getting-started/suggestionlist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Suggestionlist.cs" %}
{% include code-snippet/autocomplete/getting-started/suggestionlist/suggestionlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to bind the data](./data-binding/)