---
layout: post
title: How to render ##Platform_Name## MultiSelectFor in MVC | Syncfusion
description: Render Syncfusion ##Platform_Name## MultiSelectFor HtmlHelper in ASP.NET MVC by binding model values and selecting items via the post method on submit.
platform: ej2-asp-core-mvc
control: Ejfor
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to render ##Platform_Name## MultiSelectFor in MVC

The MultiSelectFor control can be rendered by passing values and data from the model. The selected values can be retrieved during form submit using the post method.

In the following sample, MultiSelectFor control is rendered.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/For/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/multiselect/how-to/For/For.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/For/razor %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/multiselect/how-to/For/For.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Data Annotation

Data Annotations help us to define the rules to the model classes or properties for data validation and displaying suitable messages to end users.

Data Annotations includes built-in validation attributes for different validation rules, which can be applied to the properties of model class. ASP.NET Framework will automatically enforce these validation rules and display validation messages in the view.

Using `value` property gets or sets the value of the selected item in the control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/data-model/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/multiselect/how-to/data-model/For.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/data-model/razor %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/multiselect/how-to/data-model/For.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


