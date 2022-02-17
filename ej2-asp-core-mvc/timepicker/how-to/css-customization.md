---
layout: post
title: Css Customization in ##Platform_Name## Timepicker Component
description: Learn here all about Css Customization in Syncfusion ##Platform_Name## Timepicker component and more.
platform: ej2-asp-core-mvc
control: Css Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# CSS customization

TimePicker allows you to customize the textbox and popup list appearance to suit your
application by using
[cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.TimePicker.html#Syncfusion_EJ2_Calendars_TimePicker_CssClass) property.

The below sample demonstrates customization of text appearance in a textbox, popup button, and popup list along with hover and active
state by using `e-custom-style` class. Following is the list of available classes used to customize the entire TimePicker component.

| **Class Name** | **Description** |
| --- | --- |
| e-time-wrapper | Applied to TimePicker wrapper element. |
| e-timepicker |  Applied to input element and TimePicker popup element. |
| e-time-wrapper.e-timepicker | Applied to input element only. |
| e-input-group-icon.e-time-icon | Applied to popup button. |
| e-float-text | Applied to floating label text element. |
| e-popup | Applied to popup element. |
| e-timepicker.e-popup | Applied to TimePicker popup element only. |
| e-list-parent | Applied to popup UL element. |
| e-timepicker.e-list-parent | Applied to TimePicker popup UL element only. |
| e-list-item | Applied to LI elements. |
| e-hover | Applied to LI element hovering time. |
| e-active | Applied to active LI element. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/how-to/css/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Css.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/how-to/css/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Css.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

