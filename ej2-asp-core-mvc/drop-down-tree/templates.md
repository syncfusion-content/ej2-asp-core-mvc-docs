---
layout: post
title: Templates in ##Platform_Name## Syncfusion Dropdown Tree Control
description: Learn here all about templates in Syncfusion ##Platform_Name## Dropdown Tree control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in Dropdown Tree Control

The Dropdown Tree provides support to customize each list item, header, and footer elements. It uses the Essential<sup style="font-size:70%">&reg;</sup> JS 2 [Template engine](../../common/template-engine) to compile and render the elements properly.

## Item template

The content of each list item within the Dropdown Tree can be customized with the help of `itemTemplate` property.

In the following sample, the Dropdown Tree list items are customized with employee information such as **name** and **job** using the [**itemTemplate**](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_ItemTemplate) property.

The template expression should be provided inside the ${...} interpolation syntax.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/itemTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dropdowntree/templates/itemTemplate/CSHTML.cs %}
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

![DropDown Tree with ItemTemplate](./images/item-template.PNG)

## Value template

The currently selected value that is displayed by default on the Dropdown Tree input element can be customized using the [`valueTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_ValueTemplate) property.

In the following sample, the selected value is displayed as a combined text of both `Name` and `Job` in the Dropdown Tree input, which is separated by a hyphen.

The template expression should be provided inside the ${...} interpolation syntax.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/valueTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dropdowntree/templates/valueTemplate/CSHTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/valueTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValueTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/valueTemplate/valueTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/valueTemplate/DropDownTreeTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
![DropDown Tree with ValueTemplate](./images/value-template.PNG)

## Header template

The header element is shown statically at the top of the popup list items within the Dropdown Tree. A custom element can be placed as a header element using the [`headerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_HeaderTemplate) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/headerTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dropdowntree/templates/headerTemplate/CSHTML.cs %}
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

![DropDown Tree itemTemplate Sample](./images/header-template.PNG)

## Footer template

The Dropdown Tree has options to show a footer element at the bottom of the list items in the popup list. Here, you can place any custom element as a footer element using the [`footerTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_FooterTemplate) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/footerTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dropdowntree/templates/footerTemplate/CSHTML.cs %}
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

![DropDown Tree itemTemplate Sample](./images/footer-template.PNG)

## No records template

The Dropdown Tree is supports to display custom design in the popup list content using the [`noRecordsTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_NoRecordsTemplate) property when no matches found on search.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/noRecordsTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dropdowntree/templates/noRecordsTemplate/CSHTML.cs %}
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

![DropDown Tree itemTemplate Sample](./images/noRecords-template.PNG)

## Action failure template

The Dropdown Tree provides an option to custom design the popup list content using [`actionFailureTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_ActionFailureTemplate) property, when the data fetch request fails at the remote server.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/actionFailureTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dropdowntree/templates/actionFailureTemplate/CSHTML.cs %}
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

![DropDown Tree itemTemplate Sample](./images/actionFailure-template.PNG)

## Custom template to show selected items in input

In Dropdown Tree, while selecting more than one item via checkbox or multi selection support, all the selected items will be displayed in the input. Instead of displaying all the selected item text, the custom template can be displayed by setting the `mode` property as ***Custom*** and [`customTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.dropdowntree.html#Syncfusion_EJ2_DropDowns_DropDownTree_CustomTemplate) property.

When the **mode** property is set as **Custom**, the Dropdown Tree displays the default template value **(${value.length} item(s) selected)** like **1 item(s) selected or 2 item(s) selected**. The default template can be customized by setting **customTemplate**  property.

In the following sample, the Dropdown Tree is rendered with default value of the **customTemplate** property like “**1 item(s) selected or 2 item(s) selected**”.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/customTemplate_mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate_mode/CSHTML.cs %}
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

![DropDown Tree itemTemplate Sample](./images/custom-template-mode.PNG)

In the following sample, the Dropdown Tree is rendered with custom value of the **customTemplate** property like **Selected items count: 2**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/customTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dropdowntree/templates/customTemplate/CSHTML.cs %}
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

![DropDown Tree itemTemplate Sample](./images/custom-template.PNG)