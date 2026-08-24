---
layout: post
title: Template in ##Platform_Name## Speed Dial | Syncfusion
description: Learn about the templates available in the Syncfusion ##Platform_Name## Speed Dial, including item and popup templates for customizing content and layout.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template in ##Platform_Name## Speed Dial

This section explains available templates in Speed Dial Control and its usage.

## Item template

You can use the [ItemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_ItemTemplate) property to set a template content for the `SpeedDialItem`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/template/itemtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemTemplate.cs" %}
{% include code-snippet/speeddial/template/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial ItemTemplate](images/SpeedDial-ItemTemplate.png)

## Popup template

You can use the [PopupTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.SpeedDial.html#Syncfusion_EJ2_Buttons_SpeedDial_PopupTemplate) property to set a template content for popup of  SpeedDial control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/speeddial/template/popuptemplate/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC SpeedDial PopupTemplate](images/SpeedDial-PopupTemplate.png)