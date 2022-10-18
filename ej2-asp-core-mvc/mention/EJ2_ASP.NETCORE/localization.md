---
layout: post
title: Localization in ##Platform_Name## Mention Component
description: Learn here all about localization in Syncfusion ##Platform_Name## Mention component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Localization

The Localization library allows you to localize static text content of the [noRecordsTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_NoRecordsTemplate) &nbsp;properties according to the culture currently assigned to the Mention.

| Locale key | en-US (default)  |
|------|------|
| noRecordsTemplate |  No records found |

## Loading translations

To load the translation object to your application, use the load function of the **L10n** class.

In the following sample, French culture is set to the mention control and no data is loaded. Hence, the [noRecordsTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_NoRecordsTemplate) property displays its text in French culture initially.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/localization/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Localization](../images/localization.png)

## See Also

* [Accessibility](./accessibility)