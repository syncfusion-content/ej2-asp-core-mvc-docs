---
layout: post
title: How to render ##Platform_Name## DropDownListFor in MVC | Syncfusion
description: Render Syncfusion ##Platform_Name## DropDownListFor HtmlHelper in ASP.NET MVC by binding model values and selecting items via the post method on submit.
platform: ej2-asp-core-mvc
control: Ejfor
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to render ##Platform_Name## DropDownListFor in MVC

The [DropDownListFor](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownListForBuilder.html) control can be rendered by passing values and data from the model. The selected values can be retrieved during form submit using the post method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/For/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/dropdownlist/how-to/For/For.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/dropdownlist/how-to/For/Countries.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/For/razor %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/dropdownlist/how-to/For/For.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/dropdownlist/how-to/For/Countries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Data Annotation

Data Annotations help define the rules for the model classes or properties for data validation and displaying suitable messages to end users.

Data Annotations include built-in validation attributes for different validation rules, which can be applied to the properties of the model class. ASP.NET Framework will automatically enforce these validation rules and display validation messages in the view.

The [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Value) property gets or sets the value of the selected item in the control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/data-model/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/dropdownlist/how-to/data-model/For.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/data-model/razor %}
{% endhighlight %}
{% highlight c# tabtitle="For.cs" %}
{% include code-snippet/dropdownlist/how-to/data-model/For.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

