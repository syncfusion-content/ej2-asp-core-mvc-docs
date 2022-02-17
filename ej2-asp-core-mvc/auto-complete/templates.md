---
layout: post
title: Templates in ##Platform_Name## Auto Complete Component
description: Learn here all about Templates in Syncfusion ##Platform_Name## Auto Complete component and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Templates

The AutoComplete has been provided with several options to customize each list items, group title, header
and footer elements. It uses the Essential JS 2 `Template engine` to compile
and render the elements properly.

## Item template

The content of each list item within the AutoComplete can be customized with the help of
[itemTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~ItemTemplate.html) property.

In the following sample, each list item is split into two columns to display relevant data's.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/itemtemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/autocomplete/templates/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/itemtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/autocomplete/templates/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Group template

The group header title under which appropriate sub-items are categorized can also be customize
with the help of [groupTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~GroupTemplate.html) property. This template is common
for both inline and floating group header template.

In the following sample, employees are grouped according to their city.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/grouptemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouptemplate.cs" %}
{% include code-snippet/autocomplete/templates/grouptemplate/grouptemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/grouptemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouptemplate.cs" %}
{% include code-snippet/autocomplete/templates/grouptemplate/grouptemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header template

The header element is shown statically at the top of the suggestion list items
within the AutoComplete, and any custom element can be placed as a header element using
[headerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~HeaderTemplate.html) property.

In the following sample, the list items and its headers are designed and displayed as two columns similar to multiple columns of the grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/headertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/autocomplete/templates/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/headertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/autocomplete/templates/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Footer template

The AutoComplete has options to show a footer element at the bottom of the list items in the
suggestion list. Here, you can place any custom element as a footer element using
[footerTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~FooterTemplate.html) property.

In the following sample, footer element displays the total number of list items present in the AutoComplete.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/footertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Footertemplate.cs" %}
{% include code-snippet/autocomplete/templates/footertemplate/footertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/footertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Footertemplate.cs" %}
{% include code-snippet/autocomplete/templates/footertemplate/footertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## No records template

The AutoComplete is provided with support to custom design the suggestion list content when no data is
found and no matches found on search with the help of
[`noRecordsTemplate`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~NoRecordsTemplate.html) property.

In the following sample, suggestion list content displays the notification of no data available.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/norecordstemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Norecordstemplate.cs" %}
{% include code-snippet/autocomplete/templates/norecordstemplate/norecordstemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/norecordstemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Norecordstemplate.cs" %}
{% include code-snippet/autocomplete/templates/norecordstemplate/norecordstemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Action failure template

There is also an option to custom design the suggestion list content when the data fetch request
fails at the remote server. This can be achieved using the
[actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoComplete~ActionFailureTemplate.html) property.

In the following sample, when the data fetch request fails, the AutoComplete displays the notification.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/actionfailuretemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Actionfailuretemplate.cs" %}
{% include code-snippet/autocomplete/templates/actionfailuretemplate/actionfailuretemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/templates/actionfailuretemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Actionfailuretemplate.cs" %}
{% include code-snippet/autocomplete/templates/actionfailuretemplate/actionfailuretemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to acheive filtering](./filtering/)
* [How to group the data using header](./grouping#grouping)
* [How to show the list items with icon](./how-to/icon-support/)