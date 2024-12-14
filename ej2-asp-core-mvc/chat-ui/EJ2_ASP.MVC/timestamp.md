---
layout: post
title: Timestamp in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Timestamp in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Timestamp
publishingplatform: ##Platform_Name##
documentation: ug
---

# Timestamp in ##Platform_Name## Chat UI control

## Show or hide timestamp

You can use the `ShowTimeStamp` property to enable or disable timestamps for all messages which displays the exact date and time when they were sent. By default, the value is `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/timestamp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Timestamp.cs" %}
{% include code-snippet/chat-ui/timestamp/timestamp.cs %}
{% endhighlight %}
{% endtabs %}

![Timestamp](images/timestampMain.png)

## Setting timestamp format

You can use the `TimeStampFormat` property to display time formats for all the messages which are displayed with the messages being sent. By default, the value is `dd/MM/yyyy hh:mm a`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/timestampFormat/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TimestampFormat.cs" %}
{% include code-snippet/chat-ui/timestampFormat/timestampFormat.cs %}
{% endhighlight %}
{% endtabs %}

![TimestampFormat](images/timestampFormatMain.png)
