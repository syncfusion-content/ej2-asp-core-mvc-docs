---
layout: post
title: Show Items Count In Group Header in ##Platform_Name## Listview Component
description: Learn here all about Show Items Count In Group Header in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Show Items Count In Group Header
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show Items Count in Group Header

The ListView component supports wrapping list items into a group based on the category. The category of each list item can
be mapped with groupBy field of the data source. You can display grouped list items count in the list-header using the group
header template. Refer to the following code sample to display grouped list item count.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/count/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/count/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/count/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

