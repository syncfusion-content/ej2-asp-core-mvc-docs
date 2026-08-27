---
layout: post
title: Set Clear Button in Calendar in ##Platform_Name## Calendar | Syncfusion
description: Learn here all about how to set a clear button in Calendar in Syncfusion ##Platform_Name## Calendar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Set Clear Button in Calendar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Set Clear Button in Calendar Control

To configure a clear button in Calendar UI, do the following:

1. Bind the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Created) event on the Calendar tag and add the required elements to make the clear button visible. In the following example, an HTML button styled with Essential JS 2 button classes is used.

2. The footer container uses the `e-footer-container` class. The clear button is prepended to this existing footer element.

3. Using this button, the selected date can be cleared.

4. Bind a click handler to the button to clear the selected value. The handler is attached in script after the button is created.

5. Add the `.e-clear` CSS rule to position the clear button within the footer.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/settoday/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Settoday.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/howto/settoday/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Settoday.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Calendar/CalendarHowToSample).