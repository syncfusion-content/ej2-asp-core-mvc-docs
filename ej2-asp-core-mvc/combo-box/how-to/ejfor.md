---
layout: post
title: Ejfor in ##Platform_Name## Combo Box Component
description: Learn here all about Ejfor in Syncfusion ##Platform_Name## Combo Box component and more.
platform: ej2-asp-core-mvc
control: Ejfor
publishingplatform: ##Platform_Name##
documentation: ug
---


# ComboBoxFor

The ComboBoxFor component can be rendered by passing values and data from the model. The selected values can be retrieved during form submit using the post method.

In the following sample, ComboBoxFor component is rendered.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/For/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/combobox/how-to/For/For.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/For/razor %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/combobox/how-to/For/For.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Data Annotation

Data Annotations help us to define the rules to the model classes or properties for data validation and displaying suitable messages to end users.

Data Annotations includes built-in validation attributes for different validation rules, which can be applied to the properties of model class. ASP.NET MVC Framework will automatically enforce these validation rules and display validation messages in the view.

Using `value` property gets or sets the value of the selected item in the component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/data-model/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/combobox/how-to/data-model/For.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/data-model/razor %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/combobox/how-to/data-model/For.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


