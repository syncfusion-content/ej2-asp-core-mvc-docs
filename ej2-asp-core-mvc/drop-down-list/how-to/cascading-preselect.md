---
layout: post
title: Preselect cascading DropDownList values | Syncfusion
description: Preselect values into cascading Syncfusion ##Platform_Name## DropDownLists from a model using the DataManager create event and filter operations.
platform: ej2-asp-core-mvc
control: Cascading Preselect
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to preselect cascading ##Platform_Name## DropDownList values

The cascading DropDownList is a series of DropDownLists, where the value of one DropDownList depends upon another's value. Values can be preselected in these DropDownLists from model. Use the DataManager to perform the filtering operation on the JSON data for cascading via the created event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/cascading-preselect/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/dropdownlist/how-to/cascading-preselect/Country.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/cascading-preselect/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/dropdownlist/how-to/cascading-preselect/Country.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

