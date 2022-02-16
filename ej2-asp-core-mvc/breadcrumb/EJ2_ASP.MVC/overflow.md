---
layout: post
title: Overflow in ##Platform_Name## Breadcrumb Component
description: Learn here all about Overflow in Syncfusion ##Platform_Name## Breadcrumb component and more.
platform: ej2-asp-core-mvc
control: Overflow
publishingplatform: ##Platform_Name##
documentation: ug
---


# Overflow Mode in breadcrumb

## Overflow Mode

In the Breadcrumb component, `maxItems` and `overflowMode` properties were used to limit the number of breadcrumb items to be displayed.

The following overflow modes are available in the Breadcrumb component.

`Default` - Specified maxItems count will be visible and the remaining items will be hidden. While clicking on the previous item, the hidden item will become visible.

`Collapsed` - Only the first and last items will be visible, and the remaining items will be hidden in the collapsed icon. When the collapsed icon is clicked, all items will become visible.

In the following example, the maxItems is set as 3 with overflowMode as Default. To prevent breadcrumb item navigation, the `enableNavigation` property has been set to false in the Breadcrumb component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/overflow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/overflow/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/overflow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/overflow/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/overflow.PNG)