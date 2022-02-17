---
layout: post
title: Getting Started with ##Platform_Name## Multi Select Component
description: Checkout and learn about getting started with ##Platform_Name## Multi Select component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our components.

This section briefly explains how to include simple MultiSelect control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

## Initialize MultiSelect control to the Application

MultiSelect control can be rendered by using the `EJS().MultiSelect()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the MultiSelect.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/getting-started/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/multiselect/getting-started/default/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/getting-started/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/multiselect/getting-started/default/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Running the above code will display the basic AutoComplete on the browser.

## Binding data source

After initialization, populate the MultiSelect with data using the [dataSource](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~DataSource.html) property.
Here, an array of string values is passed to the MultiSelect component.

The following example illustrates the output in your browser.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/multiselect/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/multiselect/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Configure the popup list

By default, the width of the popup list automatically adjusts according to the MultiSelect input element's width, and the height auto adjust's according to the height of the popup list items.

The height and width of the popup list can also be customized using the
[popupHeight](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~PopupHeight.html)
and [popupWidth](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~PopupWidth.html) properties
respectively.

In the following sample, popup list's width and height are configured.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/getting-started/suggestionlist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Suggestionlist.cs" %}
{% include code-snippet/multiselect/getting-started/suggestionlist/suggestionlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/getting-started/suggestionlist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Suggestionlist.cs" %}
{% include code-snippet/multiselect/getting-started/suggestionlist/suggestionlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to bind the data](./data-binding/)