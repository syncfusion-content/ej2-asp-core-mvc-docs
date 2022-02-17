---
layout: post
title: Set Different Work Hours in ##Platform_Name## Schedule Component
description: Learn here all about Set Different Work Hours in Syncfusion ##Platform_Name## Schedule component and more.
platform: ej2-asp-core-mvc
control: Set Different Work Hours
publishingplatform: ##Platform_Name##
documentation: ug
---

# Set Different Working Hours on Different Days

By default, the work hours of the Scheduler is highlighted based on the start and end values provided within the `workHours` property which remains same for all days. To highlight different work hours range for different days,`setWorkHours` method. You can pass date object/ multiple date objects collection as first argument and start and end time need to be added as work hours should be passed as second and third arguments respectively. In the following code example, on button click 11:00 AM to 08:00 PM of 15th and 17th February has been added in work hours.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/different-workhours/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/different-workhours/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/different-workhours/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/different-workhours/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

