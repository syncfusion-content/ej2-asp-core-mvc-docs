---
layout: post
title: Check List in ##Platform_Name## Listview Component
description: Learn here all about Check List in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Check List
publishingplatform: ##Platform_Name##
documentation: ug
---


# Checklist

The ListView supports checkbox in default and group-lists which is used to select multiple items.
The checkbox can be enabled by the `showCheckBox` property.

The Checkbox will be useful in the scenario where we need to select multiple options. For Example,
In Shipping cart we can be able to select or unselect the desired items before checkout and also
it will be useful in selecting multiple items that belongs to same category using the group list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/checklist/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/checklist/default/ListController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/checklist/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/checklist/default/ListController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core ListView - CheckList Sample](./images/checklist.png)

## Checkbox Position

In ListView the checkbox can be positioned into either `Left` or `Right` side of the list-item text.
This can be achieved by `checkBoxPositon` property. By default, checkbox will be positioned to `Left` of list-item text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/checklist/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/checklist/position/ListController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/checklist/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/checklist/position/ListController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core ListView - CheckBox Position](./images/checkbox-position.png)