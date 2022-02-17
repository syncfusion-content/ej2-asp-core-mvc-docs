---
layout: post
title: Autofill in ##Platform_Name## Auto Complete Component
description: Learn here all about Autofill in Syncfusion ##Platform_Name## Auto Complete component and more.
platform: ej2-asp-core-mvc
control: Autofill
publishingplatform: ##Platform_Name##
documentation: ug
---


# Autofill supported with AutoComplete

The AutoComplete supports the autofill behavior with the help of
[autofill](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~AutoFill.html) property. Whenever you change the
input value, the AutoComplete will autocomplete your data by matching the typed
character. Suppose, if no matches found then, AutoComplete doesn't suggest any item.

In the below sample, showcase that how to work `autofill` with AutoComplete.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/autofill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Autofill.cs" %}
{% include code-snippet/autocomplete/how-to/autofill/autofill.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/autofill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Autofill.cs" %}
{% include code-snippet/autocomplete/how-to/autofill/autofill.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


