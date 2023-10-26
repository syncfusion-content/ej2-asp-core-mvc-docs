---
layout: post
title: Localization in ##Platform_Name## Drop Down List Component
description: Learn here all about localization in Syncfusion ##Platform_Name## Drop Down List component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Localization in ASP.NET MVC DropDownList control

The Localization library allows to localize static text content of the [noRecordsTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListBuilder.html#Syncfusion_EJ2_DropDowns_DropDownListBuilder_NoRecordsTemplate_System_String_) and [actionFailureTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListBuilder.html#Syncfusion_EJ2_DropDowns_DropDownListBuilder_ActionFailureTemplate_System_String_) properties according to the culture currently assigned to the DropDownList.

| Locale key | en-US (default) |
|------------|-----------------|
| noRecordsTemplate |  No records found |
| actionFailureTemplate | The request failed |

## Loading translations

To load translation object to your application, use load function of the **L10n** class.

In the following sample, French culture is set to the DropDownList and no data is loaded. Hence, the [noRecordsTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListBuilder.html#Syncfusion_EJ2_DropDowns_DropDownListBuilder_NoRecordsTemplate_System_String_) property displays its text in French culture initially, and if the sample is run offline, the [actionFailureTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListBuilder.html#Syncfusion_EJ2_DropDowns_DropDownListBuilder_ActionFailureTemplate_System_String_) property displays its text appropriately.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/dropdownlist/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/dropdownlist/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Accessibility](./accessibility/)
* [How to bind the data to the combobox](./data-binding/)