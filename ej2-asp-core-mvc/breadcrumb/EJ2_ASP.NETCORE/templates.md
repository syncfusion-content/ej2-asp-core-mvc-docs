---
layout: post
title: Templates in ##Platform_Name## Breadcrumb Control | Syncfusion
description: Learn here all about Templates in Syncfusion ##Platform_Name## Breadcrumb control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Templates in Breadcrumb

The Breadcrumb component provides a way to customize the items using `itemTemplate` and the separators using `separatorTemplate` properties.

## Item Template

In the following example, Shopping Cart details are used as breadcrumb Items and the items are customized by the chips component using `itemTemplate`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/item-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/item-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/item-template/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![ASP.NET Core Breadcrumb with Item Template](images/item-template.PNG)

## Separator Template

In the following example, the separators are customized with icons using `separatorTemplate`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/separator-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/separator-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/separator-template/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Core Breadcrumb with Separator Template](images/separator-temp.PNG)

## Customize Specific Item Template

The specific breadcrumb item can be customizable using itemTemplate with conditional rendering. In the following example, added the span element only for the `breadcrumb` text in breadcrumb item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/specific-item-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/specific-item-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/specific-item-template/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Customizing Specific Template in ASP.NET Core Breadcrumb](images/breadcrumb-specific-item-template.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Breadcrumb/OverflowandTemplateSample).