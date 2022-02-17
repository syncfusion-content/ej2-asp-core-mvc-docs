---
layout: post
title: Set Tool Tip To The Commands in ##Platform_Name## Toolbar Component
description: Learn here all about Set Tool Tip To The Commands in Syncfusion ##Platform_Name## Toolbar component and more.
platform: ej2-asp-core-mvc
control: Set Tool Tip To The Commands
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set Essential JS 2 Tooltip to the commands

The `tooltipText` property of the Toolbar item is used to set the HTML Tooltip to the commands that can be viewed as hint texts on mouse hover.

Initialize the Tooltip with the Toolbar target. Refer to the following code example:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/toolbar/how-to/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/toolbar/how-to/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Alt text](../images/toolbar_tooltip.PNG)