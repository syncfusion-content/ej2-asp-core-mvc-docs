---
layout: post
title: Icon Support in ##Platform_Name## Auto Complete Component
description: Learn here all about Icon Support in Syncfusion ##Platform_Name## Auto Complete component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Icon Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show the list items with icons

You can render **icons** to the list items by mapping the [iconCss](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteFieldSettings~IconCss.html) field. This `iconCss` field creates a span in the list item with mapped class name to allow styling as per your need.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/icons/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/how-to/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/autocomplete/how-to/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/AutoComplete/AutoCompleteCustomSample).