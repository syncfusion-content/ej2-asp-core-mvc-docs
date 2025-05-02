---
layout: post
title: Template in ##Platform_Name## Timeline Control | Syncfusion
description: Checkout and learn about Template in Syncfusion ##Platform_Name## Timeline control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template in ##Platform_Name## Timeline control

The Timeline control allows you to customize the appearance for each item by using the [template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Timeline.html#Syncfusion_EJ2_Layouts_Timeline_Template) property to modify the dot items, templated contents, progress bar styling and more.

The `template` context receives the following information:

| Type | Purpose |
| --- | --- |
| `item` | Indicates the current data of the Timeline item. |
| `itemIndex` | Indicates the current index of the Timeline item. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/template/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Template](images/template.png)
