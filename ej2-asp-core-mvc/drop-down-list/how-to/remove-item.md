---
layout: post
title: How to remove items from ##Platform_Name## DropDownList | Syncfusion
description: Removes the item at the given index from the DropDownList and supports optional success and failure callback handlers.
platform: ej2-asp-core-mvc
control: Remove Item
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to remove items from ##Platform_Name## DropDownList

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

