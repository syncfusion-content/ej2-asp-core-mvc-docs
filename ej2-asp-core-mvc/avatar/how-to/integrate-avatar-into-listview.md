---
layout: post
title: Integrate Avatar Into ListView in ##Platform_Name## Avatar Component
description: Learn here all about how to integrate Avatar into ListView in Syncfusion ##Platform_Name## Avatar component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Integrate Avatar Into ListView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integrate Avatar into ListView

Avatar is integrated into the ListView to create contacts applications. The `xsmall` size Avatar is used to match the size of the list items. Both letters and images are also used as Avatar content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/avatar/listview/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/avatar/listview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/avatar/listview/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Avatar ListView](../images/list.PNG)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Avatar/AvatarUGSample).