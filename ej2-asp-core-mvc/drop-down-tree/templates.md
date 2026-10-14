---
layout: post
title: Templates in ##Platform_Name## DropdownTree | Syncfusion
description: Customize each Syncfusion ##Platform_Name## DropdownTree list item, header, and footer with the Essential JS 2 Template engine via the template property.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in ##Platform_Name## DropdownTree

The DropdownTree provides support to customize each list item, header, and footer elements. It uses the Essential<sup style="font-size:70%">&reg;</sup> JS 2 [Template engine](../../common/template-engine) to compile and render the elements properly.

## Item template

The content of each list item within the DropdownTree can be customized with the help of `itemTemplate` property.

In the following sample, the DropdownTree list items are customized with employee information such as **name** and **job** using the **itemTemplate** property.

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

![DropdownTree with ItemTemplate](./images/item-template.PNG)

## Value template

The currently selected value that is displayed by default on the DropdownTree input element can be customized using the `valueTemplate` property.

In the following sample, the selected value is displayed as a combined text of both `Name` and `Job` in the DropdownTree input, which is separated by a hyphen.

The template expression should be provided inside the ${...} interpolation syntax.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdowntree/templates/valueTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValueTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/valueTemplate/valueTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="DropDownTreeTemplate.cs" %}
{% include code-snippet/dropdowntree/templates/valueTemplate/DropDownTreeTemplate.cs %}
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
![DropdownTree with ValueTemplate](./images/value-template.PNG)

## Header template

The header element is shown statically at the top of the popup list items within the DropdownTree. A custom element can be placed as the header element using the `headerTemplate` property.

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

![DropdownTree header template sample](./images/header-template.PNG)

## Footer template

The DropdownTree has options to show a footer element at the bottom of the list items in the popup list. Here, you can place any custom element as a footer element using the `footerTemplate` property.

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

![DropdownTree footer template sample](./images/footer-template.PNG)

## No records template

The DropdownTree supports displaying custom design in the popup list content using the `noRecordsTemplate` property when no matches are found during search.

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

![DropdownTree no records template sample](./images/noRecords-template.PNG)

## Action failure template

The DropdownTree provides an option to custom design the popup list content using `actionFailureTemplate` property, when the data fetch request fails at the remote server.

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

![DropdownTree iaction failure template sample](./images/actionFailure-template.PNG)

## Custom template to show selected items in input

In DropdownTree, while selecting more than one item via checkbox or multi selection support, all the selected items will be displayed in the input. Instead of displaying all the selected item text, the custom template can be displayed by setting the `mode` property as ***Custom*** and `customTemplate` property.

When the **mode** property is set to **Custom**, the DropdownTree displays the default template value **(${value.length} item(s) selected)** like **1 item(s) selected or 2 item(s) selected**. The default template can be customized by setting **customTemplate**  property.

In the following sample, the DropdownTree is rendered with default value of the **customTemplate** property like “**1 item(s) selected or 2 item(s) selected**”.


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

![DropdownTree custom template sample](./images/custom-template-mode.PNG)

In the following sample, the DropdownTree is rendered with custom value of the **customTemplate** property like **Selected items count: 2**.

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

![DropdownTree custom template sample](./images/custom-template.PNG)