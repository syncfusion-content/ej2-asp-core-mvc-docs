---
layout: post
title: Templates in ##Platform_Name## Breadcrumb Component
description: Learn here all about Templates in Syncfusion ##Platform_Name## Breadcrumb component and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Templates in Breadcrumb

The Breadcrumb provides a way to customize the items using `itemTemplate` and the separators using `separatorTemplate` properties.

## Item Template

In the following example, Shopping Cart details are used as breadcrumb Items and the items are customized by the chips component using `itemTemplate`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/item-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/item-template/default.cs %}
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



Output be like the below.

![Breadcrumb Sample](./images/item-template.PNG)

## Separator Template

In the  following example, the separators are customized with icons using `separatorTemplate`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/separator-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/separator-template/default.cs %}
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



Output be like the below.

![Breadcrumb Sample](./images/separator-temp.PNG)