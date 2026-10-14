---
layout: post
title: Localization in ##Platform_Name## MultiSelect | Syncfusion
description: Localize Syncfusion ##Platform_Name## MultiSelect no-records and action-failure template text using locale values and translation objects for global apps.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization in ##Platform_Name## MultiSelect

The Localization library allows you to localize the static text content of the [noRecordsTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_NoRecordsTemplate) and [actionFailureTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ActionFailureTemplate) properties according to the culture currently assigned to the MultiSelect.

| Locale key | en-US (default) |
| --- | --- |
| `noRecordsTemplate` | No records found |
| `actionFailureTemplate` | The request failed |

## Loading translations

To load a translation object into your application, use the `load` function of the **L10n** class.

In the following sample, the French culture is set on the MultiSelect and no data is loaded. The [noRecordsTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_NoRecordsTemplate) property initially displays its text in French. If the sample is run offline, the [actionFailureTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ActionFailureTemplate) property displays its text appropriately.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/multiselect/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/multiselect/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [Accessibility](./accessibility)
* [How to bind the data to the combobox](./data-binding)