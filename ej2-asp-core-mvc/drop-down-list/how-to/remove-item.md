---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Remove Item of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Remove Item
publishingplatform: ##Platform_Name##
documentation: ug
---


# Remove an item from DropDownList

The following example demonstrate about how to remove an item from DropDownList.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/removeitem/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/dropdownlist/how-to/removeitem/GameList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/removeitem/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/dropdownlist/how-to/removeitem/GameList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

