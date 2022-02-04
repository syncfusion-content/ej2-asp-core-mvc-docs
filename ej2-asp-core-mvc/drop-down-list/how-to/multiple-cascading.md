---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Multiple Cascading of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Multiple Cascading
publishingplatform: ##Platform_Name##
documentation: ug
---


# Preselect the list items in multiple cascading DropDownList

The following example demonstrate about how to preselect the list items in multiple cascading DropDownList.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/preselectcascade/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/dropdownlist/how-to/preselectcascade/Country.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/preselectcascade/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/dropdownlist/how-to/preselectcascade/Country.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

