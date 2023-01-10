---
layout: post
title: Templates in ASP.NET MVC Mention control | Syncfusion
description: Learn here all about templates in Syncfusion ASP.NET MVC Mention control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ejmvc
documentation: ug
---

# Templates in Mention

The Mention has been provided with several options to customize each suggestion list item, display item, and data loading indication.

## Item template

The content of each list item in the Mention can be customized using the [ItemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ItemTemplate) property.

In the following sample, each list item is split into two columns to display relevant data using `ItemTemplate`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/template/item-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/template/item-template/item-template.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Mention item template](./images/mention-item-template.png)

## Display template

You can customize the mentioned value's display appearance using the [DisplayTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_DisplayTemplate) property.

In the following sample, the selected value is displayed as a combined text of both FirstName and City in the mention element, which is separated by a hyphen.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/template/display-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/template/display-template/display-template.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Mention display template](./images/mention-display-template.png)

## No records template

You can show the custom design of the popup list content when no data and matches are found on the search with the help of [NoRecordsTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_NoRecordsTemplate) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/template/noRecord-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/template/noRecord-template/noRecord-template.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Mention no record template](./images/mention-noRecord-template.png)

## Spinner template

Display the customized waiting spinner, when data fetching takes time to load in the suggestion list by using the [SpinnerTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SpinnerTemplate) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/template/spinner-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/template/spinner-template/spinner-template.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Mention spinner template](./images/mention-spinner-template.png)

## See also

* [How to achieve filtering](./filtering-data)