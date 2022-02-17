---
layout: post
title: Set Command Customization in ##Platform_Name## Toolbar Component
description: Learn here all about Set Command Customization in Syncfusion ##Platform_Name## Toolbar component and more.
platform: ej2-asp-core-mvc
control: Set Command Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set command customization

The `htmlAttributes` property of the Toolbar item is used to set the HTML attributes ('ID', 'class', 'style' ,'role') for the commands.

When style attributes are added, if the same attributes were already present, they will be replaced. This is not so in the case of `class` attribute. Classes will be added to the element instead of replacing the existing ones.

Single or multiple CSS classes can be added to the Toolbar commands using the Toolbar item `cssClass` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/toolbar/how-to/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% include code-snippet/toolbar/how-to/customization/customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Alt text](../images/toolbar_command.PNG)