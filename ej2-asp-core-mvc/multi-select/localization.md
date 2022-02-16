---
layout: post
title: Localization in ##Platform_Name## Multi Select Component
description: Learn here all about Localization in Syncfusion ##Platform_Name## Multi Select component and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization

The Localization library allows you to localize static text content of the
[noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~NoRecordsTemplate.html)
 and [actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~ActionFailureTemplate.html)
&nbsp;properties according to the culture currently assigned to the MultiSelect.

| Locale key | en-US (default)
|------|------
| noRecordsTemplate |  No records found
| actionFailureTemplate | The request failed

## Loading translations

To load translation object to your application, use load function of the **L10n** class.

In the following sample, French culture is set to the MultiSelect and no data is loaded. Hence, the [noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~NoRecordsTemplate.html) property displays its text in French culture initially, and if the sample is run offline, the [actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~ActionFailureTemplate.html) property displays its text appropriately.

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



## See Also

* [Accessibility](./accessibility/)
* [How to bind the data to the combobox](./data-binding/)