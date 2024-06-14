---
layout: post
title: Localization in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Localization in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Localization in ##Platform_Name## MultiColumn Combobox control

The Localization library allows you to localize static text content of the [NoRecordsTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_NoRecordsTemplate) property according to the culture currently assigned to the MultiColumn ComboBox.

| Locale key | en-US (default)  |
|------|------|
| noRecordsTemplate |  No records found |

## Loading translations

To load translation object to your application, use `load` function of **L10n** class.

In the following sample, French culture is set to the MultiColumn ComboBox and no data is loaded. Hence, the noRecordsTemplate property displays its text in French culture.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/columns/localization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Localization.cs" %}
{% include code-snippet/multicolumn-combobox/columns/localization/localization.cs %}
{% endhighlight %}
{% endtabs %}

![Localization](images/localization.png)
