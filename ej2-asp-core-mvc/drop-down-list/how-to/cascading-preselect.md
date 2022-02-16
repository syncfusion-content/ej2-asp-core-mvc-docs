---
layout: post
title: Cascading Preselect in ##Platform_Name## Drop Down List Component
description: Learn here all about Cascading Preselect in Syncfusion ##Platform_Name## Drop Down List component and more.
platform: ej2-asp-core-mvc
control: Cascading Preselect
publishingplatform: ##Platform_Name##
documentation: ug
---


# Preselect value from model in Cascading DropDownList

The cascading DropDownList is a series of DropDownList, where the value of one DropDownList depends
upon  another's value. Values can be preselected in these DropDownList from model. Use the dataManager to perform the filtering operation on the JSON data for cascading through create event.

The following example, shows how to preselect value from model in cascade DropDownList.

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

