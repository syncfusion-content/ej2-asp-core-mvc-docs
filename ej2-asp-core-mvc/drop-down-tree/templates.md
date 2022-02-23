---
layout: post
title: Templates in ##Platform_Name## Drop Down Tree Component
description: Learn here all about Templates in Syncfusion ##Platform_Name## Drop Down Tree component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in Drop Down Tree Component

The Dropdown Tree provides support to customize each list item, header, and footer elements. It uses the Essential JS 2 [Template engine](../../common/template-engine) to compile and render the elements properly.

## Item template

The content of each list item within the Dropdown Tree can be customized with the help of `itemTemplate` property.

In the following sample, the Dropdown Tree list items are customized with employee information such as **name** and **job** using the **itemTemplate** property.

The template expression should be provided inside the ${...} interpolation syntax.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/itemTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="itemTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/itemTemplate/itemTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/itemTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/itemTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="itemTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/itemTemplate/itemTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/itemTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![##Platform_Name## DropDown Tree with ItemTemplate](./images/item-template.PNG)

## Header template

The header element is shown statically at the top of the popup list items within the Dropdown Tree. A custom element can be placed as a header element using the `headerTemplate` property.

In the following sample, the header is customized with the custom element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/headerTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="headerTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/headerTemplate/headerTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/headerTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/headerTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="headerTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/headerTemplate/headerTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/headerTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![DropDown Tree itemTemplate Sample](./images/header-template.PNG)

## Footer template

The Dropdown Tree has options to show a footer element at the bottom of the list items in the popup list. Here, you can place any custom element as a footer element using the `footerTemplate` property.

In the following sample, the footer element displays the total number of employees present in the Dropdown Tree.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/footerTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="footerTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/footerTemplate/footerTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/footerTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/footerTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="footerTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/footerTemplate/footerTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/footerTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![DropDown Tree itemTemplate Sample](./images/footer-template.PNG)

## No records template

The Dropdown Tree is supports to display custom design in the popup list content using the `noRecordsTemplate` property when no matches found on search.

In the following sample, popup list content displays the notification of no data available.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/noRecordsTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="noRecordsTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/noRecordsTemplate/noRecordsTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/noRecordsTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/noRecordsTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="noRecordsTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/noRecordsTemplate/noRecordsTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/noRecordsTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![DropDown Tree itemTemplate Sample](./images/noRecords-template.PNG)

## Action failure template

The Dropdown Tree provides an option to custom design the popup list content using `actionFailureTemplate` property, when the data fetch request fails at the remote server.

In the following sample, when the data fetch request fails, the Dropdown Tree displays the notification.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/actionFailureTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="actionFailureTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/actionFailureTemplate/actionFailureTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/actionFailureTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/actionFailureTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="actionFailureTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/actionFailureTemplate/actionFailureTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/actionFailureTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![DropDown Tree itemTemplate Sample](./images/actionFailure-template.PNG)

## Custom template to show selected items in input

In Dropdown Tree, while selecting more than one items via checkbox or multi selection support, all the selected items will be displayed in the input. Instead of displaying all the selected item text, the custom template can be displayed by setting the the `mode` property as ***Custom*** and `customTemplate` property.

When the **mode** property is set as **Custom**, the Dropdown Tree displays the default template value **(${value.length} item(s) selected)** like **1 item(s) selected or 2 item(s) selected**. The default template can be customized by setting **customTemplate**  property.

In the following sample, the Dropdown Tree is rendered with default value of the **customTemplate** property like “**1 item(s) selected or 2 item(s) selected**”.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/customTemplate_mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="customTemplatemode.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate_mode/customTemplatemode.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate_mode/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/customTemplate_mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="customTemplatemode.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate_mode/customTemplatemode.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate_mode/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![DropDown Tree itemTemplate Sample](./images/custom-template-mode.PNG)

In the following sample, the Dropdown Tree is rendered with custom value of the **customTemplate** property like **Selected items count: 2**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/customTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="customTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate/customTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/customTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="customTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate/customTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![DropDown Tree itemTemplate Sample](./images/custom-template.PNG)