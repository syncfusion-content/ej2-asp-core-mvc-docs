---
layout: post
title: Templates in ##Platform_Name## Combo Box Component
description: Learn here all about Templates in Syncfusion ##Platform_Name## Combo Box component and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Templates

The ComboBox has been provided with several options to customize each list item, group title,
selected value, header, and footer elements. It uses the Essential JS 2
Template engine to compile and render the elements properly.

## Item template

The content of each list item within the ComboBox can be customized with the
help of [itemTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~ItemTemplate.html)
property.

In the following sample, each list item is split into two columns to display relevant data's.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/itemtemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/combobox/templates/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/itemtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/combobox/templates/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Group template

The group header title under which appropriate sub-items are categorized can also be
customize with the help of
[groupTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~GroupTemplate.html) property.
This template is common for both inline and floating group header template.

In the following sample, employees are grouped according to their city.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/grouptemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouptemplate.cs" %}
{% include code-snippet/combobox/templates/grouptemplate/grouptemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/grouptemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouptemplate.cs" %}
{% include code-snippet/combobox/templates/grouptemplate/grouptemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header template

The header element is shown statically at the top of the popup list items within the
ComboBox, and any custom element can be placed as a header element using the
[headerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~HeaderTemplate.html) property.

In the following sample, the list items and its headers are designed and displayed as two columns
similar to multiple columns of the grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/headertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/combobox/templates/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/headertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/combobox/templates/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Footer template

The ComboBox has options to show a footer element at the bottom of the list items in the popup list.
Here, you can place any custom element as a footer element using the [footerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~FooterTemplate.html) property.

In the following sample, footer element displays the total number of list items present in the ComboBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/footertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Footertemplate.cs" %}
{% include code-snippet/combobox/templates/footertemplate/footertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/footertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Footertemplate.cs" %}
{% include code-snippet/combobox/templates/footertemplate/footertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## No records template

The ComboBox is provided with support to custom design the popup list content when no data is found
and no matches found on search with the help of
[noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~NoRecordsTemplate.html) property.

In the following sample, popup list content displays the notification of no data available.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/norecordstemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Norecordstemplate.cs" %}
{% include code-snippet/combobox/templates/norecordstemplate/norecordstemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/norecordstemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Norecordstemplate.cs" %}
{% include code-snippet/combobox/templates/norecordstemplate/norecordstemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Action failure template

There is also an option to custom design the popup list content when the data fetch request
fails at the remote server. This can be achieved using the
[actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~ActionFailureTemplate.html) property.

In the following sample, when the data fetch request fails, the ComboBox displays the notification.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/actionfailuretemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Actionfailuretemplate.cs" %}
{% include code-snippet/combobox/templates/actionfailuretemplate/actionfailuretemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/templates/actionfailuretemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Actionfailuretemplate.cs" %}
{% include code-snippet/combobox/templates/actionfailuretemplate/actionfailuretemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to acheive filtering](./filtering/)
* [How to group the data using header](./grouping/)
* [How to show the list items with icon](./how-to/icons-support/)