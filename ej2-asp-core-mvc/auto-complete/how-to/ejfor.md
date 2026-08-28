---
layout: post
title: Render AutoCompleteFor in ##Platform_Name## AutoComplete | Syncfusion
description: Learn here all about Ejfor in Syncfusion ##Platform_Name## Auto Complete component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ejfor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render AutoCompleteFor in ##Platform_Name## AutoComplete

The AutoCompleteFor control can be rendered by passing values and data from the model. The model class must define a property that will be bound to the AutoCompleteFor helper. The selected values can be retrieved during form submit using the post method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/For/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/autocomplete/how-to/For/For.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/For/razor %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/autocomplete/how-to/For/For.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Data annotation

Data annotations are used to define rules for model classes or properties for data validation and displaying suitable messages to end users.

Data annotations include built-in validation attributes for different validation rules, which can be applied to the properties of a model class. ASP.NET Framework will automatically enforce these validation rules and display validation messages in the view.

The `value` property gets or sets the value of the selected item in the control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/data-model/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/autocomplete/how-to/data-model/For.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/data-model/razor %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/autocomplete/how-to/data-model/For.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
