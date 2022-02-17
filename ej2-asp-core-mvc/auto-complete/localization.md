---
layout: post
title: Localization in ##Platform_Name## Auto Complete Component
description: Learn here all about Localization in Syncfusion ##Platform_Name## Auto Complete component and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization

The Localization library allows you to localize static text content of the
`noRecordsTemplate` and `actionFailureTemplate` properties according to the culture currently assigned to the AutoComplete.

| Locale key | en-US (default)
|------|------
| noRecordsTemplate |  No Records Found
| actionFailureTemplate | The Request Failed

## Loading translations

To load translation object to your application, use load function of the **L10n** class.

In the following sample, French culture is set to the AutoComplete and no data is loaded. Hence, the
[noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~NoRecordsTemplate.html) property displays its text in French culture initially and if the sample
is run offline, the [actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~ActionFailureTemplate.html) property displays its text appropriately.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/localization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/autocomplete/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/autocomplete/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Accessibility](./accessibility/)
* [How to bind the data to the autocomplete](./data-binding/)