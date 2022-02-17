---
layout: post
title: Getting Started with ##Platform_Name## Toolbar Component
description: Checkout and learn about getting started with ##Platform_Name## Toolbar component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

 This section briefly explains about how to include a simple Toolbar in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part part of the system requirements and configure the common specifications.

## Adding component to the Application

* Now open your view and controller page to render Toolbar component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/toolbar/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/toolbar/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![getting started](../../toolbar/images/gettingstarted.PNG)

## Render the Toolbar items using content template

You can bind any HTML elements or other components in Toolbar items, by simply using the content template property in ASP.NET Toolbar.

In the below demo, the Toolbar items are given as [Button](../button), [MaskedTextBox](../maskedtextbox), [RadioButton](../radio-button), [DropDownList](../drop-down-list) using the content template. In the content template property of Toolbar, you can directly render these controls like below in the code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/contenttemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Contenttemplate.cs" %}
{% include code-snippet/toolbar/how-to/contenttemplate/contenttemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/contenttemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Contenttemplate.cs" %}
{% include code-snippet/toolbar/how-to/contenttemplate/contenttemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![content template](../../toolbar/images/contenttemplate.PNG)

## See Also

* [How to add Toggle Button](./how-to/add-toggle-button)