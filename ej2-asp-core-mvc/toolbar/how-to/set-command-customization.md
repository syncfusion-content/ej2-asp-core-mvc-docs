---
layout: post
title: How to set command customization in ##Platform_Name## Toolbar | Syncfusion
description: Customize Syncfusion ##Platform_Name## Toolbar commands by setting HTML attributes like ID, class, style, and role using the `htmlAttributes` property.
platform: ej2-asp-core-mvc
control: Set Command Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# How To Set Command Customization In ##Platform_Name## Toolbar

The `htmlAttributes` property of the Toolbar item is used to set HTML attributes ('ID', 'class', 'style', 'role') for commands.

When style attributes are added and the same attributes already exist, they will be replaced. However, the `class` attribute behaves differently. Classes are appended rather than replaced.

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

The output looks like the following.

![Toolbar displaying customized command buttons with applied HTML attributes and CSS classes](../images/toolbar_command.PNG)