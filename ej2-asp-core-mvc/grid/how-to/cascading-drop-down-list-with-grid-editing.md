---
layout: post
title: Cascading Drop Down List With Grid Editing in ##Platform_Name## Grid Component
description: Learn here all about Cascading Drop Down List With Grid Editing in Syncfusion ##Platform_Name## Grid component and more.
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
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/cascading/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cascading.cs" %}
{% include code-snippet/grid/how-to/cascading/cascading.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/cascading/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Cascading.cs" %}
{% include code-snippet/grid/how-to/cascading/cascading.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

