---
layout: post
title: Grouping in ##Platform_Name## Listview Component
description: Learn here all about Grouping in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grouping

The ListView supports to wrap the nested element into a group based on the category. The category of each list item can be mapped with groupBy field in the data table, that also supports single-level navigation.

In the following sample, The cars are grouped based on its category by using the groupBy field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/grouping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/grouping/ListController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/grouping/ListController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core ListView - Grouping](./images/grouping.png)

## Customization

The grouping header can be customized by using the groupTemplate property for both inline and fixed group header. The complete customization description and explanation with an example is given in the following link.

[ASP .NET Core ListView - Group Template](./customizing-templates#group-template).