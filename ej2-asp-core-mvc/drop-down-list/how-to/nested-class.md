---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Nested Class of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Nested Class
publishingplatform: ##Platform_Name##
documentation: ug
---


# Model binding with nested class

The following example demonstrate on how to model bind data to DropDownList with nested classes in controller.

Refer to the below code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/nested-class/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nesteddata.cs" %}
{% include code-snippet/dropdownlist/how-to/nested-class/nesteddata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/nested-class/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nesteddata.cs" %}
{% include code-snippet/dropdownlist/how-to/nested-class/nesteddata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

