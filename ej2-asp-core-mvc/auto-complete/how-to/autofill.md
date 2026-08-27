---
layout: post
title: How to Enable Autofill in ##Platform_Name## AutoComplete | Syncfusion
description: Learn here all about Autofill in the ##Platform_Name## AutoComplete component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Autofill
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Enable Autofill in ##Platform_Name## AutoComplete

The AutoComplete supports the `autofill` behavior with the help of the [autofill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_Autofill) property. To enable autofill, set the `autofill` property to `true`. Whenever you change the input value, the AutoComplete will autocomplete your data by matching the typed character. If no matches are found, the AutoComplete does not apply the inline completion.

The following sample shows how to use the `autofill` property with the AutoComplete.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/autofill/tagHelper %}
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

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/AutoComplete/AutoCompleteCustomSample).