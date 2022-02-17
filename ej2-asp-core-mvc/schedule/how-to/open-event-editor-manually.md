---
layout: post
title: Open Event Editor Manually in ##Platform_Name## Schedule Component
description: Learn here all about Open Event Editor Manually in Syncfusion ##Platform_Name## Schedule component and more.
platform: ej2-asp-core-mvc
control: Open Event Editor Manually
publishingplatform: ##Platform_Name##
documentation: ug
---

# Manually Open the Event Editor

Schedule allows user to manually open the event editor on specific time or on certain events using `openEditor` method as shown below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/event-editor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/event-editor/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/event-editor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/event-editor/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

