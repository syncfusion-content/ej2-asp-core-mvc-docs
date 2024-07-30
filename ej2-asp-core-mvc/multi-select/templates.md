---
layout: post
title: Templates in ##Platform_Name## Multi Select Control | Syncfusion
description: Learn here all about Templates in Syncfusion ##Platform_Name## Multi Select component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Templates in MultiSelect Control

The MultiSelect has been provided with several options to customize each list item, group title, selected value, header, and footer elements. It uses the Essential JS 2 `Template engine` to compile and render the elements properly.

## Item template

The content of each list item within the MultiSelect can be customized with the help of [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ItemTemplate) property.

In the following sample, each list item is split into two columns to display relevant data's.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/itemtemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/multiselect/templates/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/itemtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/multiselect/templates/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Value template

The currently selected value that is displayed by default on the MultiSelect input element can be customized using the [valueTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ValueTemplate) property.

In the following sample, the selected value is displayed as a combined text of both `FirstName` and `City` in the MultiSelect input, which is separated by a hyphen.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/valuetemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Valuetemplate.cs" %}
{% include code-snippet/multiselect/templates/valuetemplate/valuetemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/valuetemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Valuetemplate.cs" %}
{% include code-snippet/multiselect/templates/valuetemplate/valuetemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Group template

The group header title under which appropriate sub-items are categorized can also be customize with the help of [groupTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_GroupTemplate) property. This template is common for both inline and floating group header template.

In the following sample, employees are grouped according to their city.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/grouptemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouptemplate.cs" %}
{% include code-snippet/multiselect/templates/grouptemplate/grouptemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/grouptemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouptemplate.cs" %}
{% include code-snippet/multiselect/templates/grouptemplate/grouptemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header template

The header element is shown statically at the top of the popup list items within the MultiSelect, and any custom element can be placed as a header element using the [headerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_HeaderTemplate) property.

In the following sample, the list items and its headers are designed and displayed as two columns similar to multiple columns of the grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/headertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/multiselect/templates/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/headertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/multiselect/templates/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Footer template

The MultiSelect has options to show a footer element at the bottom of the list items in the popup list. Here, you can place any custom element as a footer element using the [footerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_FooterTemplate) property.

In the following sample, footer element displays the total number of list items present in the MultiSelect.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/footertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Footertemplate.cs" %}
{% include code-snippet/multiselect/templates/footertemplate/footertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/footertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Footertemplate.cs" %}
{% include code-snippet/multiselect/templates/footertemplate/footertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## No records template

The MultiSelect is provided with support to custom design the popup list content when no data is found and no matches found on search with the help of [noRecordsTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_NoRecordsTemplate) property.

In the following sample, popup list content displays the notification of no data available.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/norecordstemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Norecordstemplate.cs" %}
{% include code-snippet/multiselect/templates/norecordstemplate/norecordstemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/norecordstemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Norecordstemplate.cs" %}
{% include code-snippet/multiselect/templates/norecordstemplate/norecordstemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Action failure template

There is also an option to custom design the popup list content when the data fetch request fails at the remote server. This can be achieved using the [actionFailureTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ActionFailureTemplate) property.

In the following sample, when the data fetch request fails, the MultiSelect displays the notification.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/actionfailuretemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Actionfailuretemplate.cs" %}
{% include code-snippet/multiselect/templates/actionfailuretemplate/actionfailuretemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/actionfailuretemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Actionfailuretemplate.cs" %}
{% include code-snippet/multiselect/templates/actionfailuretemplate/actionfailuretemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to bind the data](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/data-binding)
* [How to group the data using header](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/grouping)
* [How to customize the options in MultiSelect](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/chip-customization)