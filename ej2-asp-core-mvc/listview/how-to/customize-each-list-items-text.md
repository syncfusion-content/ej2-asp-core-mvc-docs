---
layout: post
title: Customize each list item's text in ListView | Syncfusion
description: Customize per-item text and HTML in Syncfusion ##Platform_Name## ListView using the template property with conditional rendering by item fields.
platform: ej2-asp-core-mvc
control: Customize Each List Item's Text in ListView
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize each list item's text in ##Platform_Name## ListView

To customize the text of each list item in the ListView control, you can make use of the `HtmlAttributes` property. This property allows you to specify HTML attributes and styles for individual items within the list, enabling you to create visually appealing and interactive lists tailored to your requirements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/customize-list-items-text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/customize-list-items-text/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/customize-list-items-text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/customize-list-items-text/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}