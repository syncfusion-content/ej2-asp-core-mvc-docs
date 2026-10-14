---
layout: post
title: Preselect Items in Cascading ##Platform_Name## DropDownList | Syncfusion
description: Preselect Syncfusion ##Platform_Name## DropDownList items in cascading scenarios from a model using value mapping and dependent change events.
platform: ej2-asp-core-mvc
control: Multiple Cascading
publishingplatform: ##Platform_Name##
documentation: ug
---


# Preselect Items in Cascading ##Platform_Name## DropDownList

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

