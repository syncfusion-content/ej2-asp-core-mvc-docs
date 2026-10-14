---
layout: post
title: Show List Items with Icons in ##Platform_Name## AutoComplete | Syncfusion
description: Learn here all about Icon Support in the ##Platform_Name## AutoComplete component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Icon Support
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show List Items with Icons in ##Platform_Name## AutoComplete

You can display **icons** in the list items by mapping the [iconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoCompleteFieldSettings.html#Syncfusion_EJ2_DropDowns_AutoCompleteFieldSettings_IconCss) field through the `fields` property. The data source must include a field whose values are CSS class names that correspond to the icons you want to show. This `iconCss` field creates a span in the list item with the mapped class name, allowing you to style it as needed.

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

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/AutoComplete/AutoCompleteCustomSample).