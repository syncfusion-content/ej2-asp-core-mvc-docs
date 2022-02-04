---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize The Events Dynamically of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize The Events Dynamically
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the Events Dynamically Before it Renders on UI

The `eventRendered` event will be triggered before rendering the appointments on Schedule where it can be customized. In the below demo, custom field **CategoryColor** is added to the appointment collection and based on certain condition, appointment background color is changed with **CategoryColor** field value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/dynamic-appointments/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/dynamic-appointments/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/dynamic-appointments/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/dynamic-appointments/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

