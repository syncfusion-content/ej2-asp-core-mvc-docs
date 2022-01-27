---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Cascading Drop Down List With Grid Editing of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Cascading Drop Down List With Grid Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Cascading DropDownList with Grid editing

You can achieve the Cascading DropDownList with grid Editing by using the Cell Edit Template feature.

In the below demo, Cascading DropDownList is rendered for the `ShipCountry` and `ShipState` column.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="cascading" %}
{% include_relative code-snippet/how-to/cascading/cascading.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="cascading" %}
{% include_relative code-snippet/how-to/cascading/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="cascading" %}
{% include_relative code-snippet/how-to/cascading/cascading.cs %}
{% endhighlight %}
{% highlight razor tabtitle="cascading" %}
{% include_relative code-snippet/how-to/cascading/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

