---
layout: post
title: Set Clear Button In Calendar in ##Platform_Name## Calendar Component
description: Learn here all about Set Clear Button In Calendar in Syncfusion ##Platform_Name## Calendar component and more.
platform: ej2-asp-core-mvc
control: Set Clear Button In Calendar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set clear button

To configure `clear` button in Calendar UI, do the following:

1. To the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.Calendar.html#Syncfusion_EJ2_Calendars_Calendar_Created)
 event of the Calendar, add the required elements to make clear button visible. In the following example, div with Essential JS 2 button control is used.

2. When the `e-footer` class is used, the div tag acts as the footer.

3. Using these button, selected date can be cleared.

4. Bind the required event handler to the button tag to update the value.

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


