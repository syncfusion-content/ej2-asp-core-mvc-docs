---
layout: post
title: Getting Started with ##Platform_Name## Radio Button Component
description: Checkout and learn about getting started with ##Platform_Name## Radio Button component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to create a simple SplitButton in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add RadioButton to the project

To create simple RadioButton add the `ejs-radiobutton` tag with id attribute as `element` in your **Index.cshtml** page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/radio-button/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/radio-button/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![RadioButton Sample](./images/radio-button.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a default rendering of RadioButton.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/radio-button/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/radio-button/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Change the RadioButton state

The Essential JS 2 RadioButton contains 2 states visually, they are as follows:
* Checked
* Unchecked

The RadioButton [`checked`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.RadioButton.html#Syncfusion_EJ2_Buttons_RadioButton_Checked) property is used to handle the checked and unchecked state.
In the checked state an inner circle will be added to the visualization of RadioButton.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/getting-started/state/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="State.cs" %}
{% include code-snippet/radio-button/getting-started/state/state.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/getting-started/state/razor %}
{% endhighlight %}
{% highlight c# tabtitle="State.cs" %}
{% include code-snippet/radio-button/getting-started/state/state.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

