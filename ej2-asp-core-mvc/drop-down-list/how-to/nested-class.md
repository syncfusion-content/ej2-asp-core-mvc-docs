---
layout: post
title: Nested Class in ##Platform_Name## Drop Down List Component
description: Learn here all about Nested Class in Syncfusion ##Platform_Name## Drop Down List component and more.
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

