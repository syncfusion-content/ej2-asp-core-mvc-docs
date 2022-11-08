---
layout: post
title: Templates in ASP.NET Core Mention control | Syncfusion
description: Learn here all about templates in Syncfusion ASP.NET Core Mention control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: aspnet-core
documentation: ug
---

# Templates in Mention

The Mention has been provided with several options to customize each suggestion list item, display item, and data loading indication.

## Item template

The content of each list item in the Mention can be customized using the [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ItemTemplate) property.

In the following sample, each list item is split into two columns to display relevant data using `itemTemplate`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/template/item-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention item template](./images/mention-item-template.png)

## Display template

You can customize the mentioned value's display appearance using the [displayTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_DisplayTemplate) property.

In the following sample, the selected value is displayed as a combined text of both FirstName and City in the mention element, which is separated by a hyphen.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/template/display-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention display template](./images/mention-display-template.png)

## No records template

You can show the custom design of the popup list content when no data and matches are found on the search with the help of [noRecordsTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_NoRecordsTemplate) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/template/noRecord-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention no record template](./images/mention-noRecord-template.png)

## Spinner template

Display the customized waiting spinner, when data fetching takes time to load in the suggestion list by using the [spinnerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SpinnerTemplate) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/template/spinner-template/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention spinner template](./images/mention-spinner-template.png)

## See also

* [How to achieve filtering](./filtering-data)