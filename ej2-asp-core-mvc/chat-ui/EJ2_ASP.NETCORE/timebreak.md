---
layout: post
title: Timebreak in ##Platform_Name## Chat UI | Syncfusion
description: Checkout and learn about Timebreak in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chat UI
publishingplatform: ##Platform_Name##
documentation: ug
---

# Time break in ##Platform_Name## Chat UI

## Show or hide time break

You can use the [showTimeBreak](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_ShowTimeBreak) property to display date-wise separations between all the messages which enhances the readability and message organizing. The default value is `false`, indicating time breaks are disabled unless it is enabled. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/timebreak/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Timebreak.cs" %}
{% include code-snippet/chat-ui/timebreak/timestamp.cs %}
{% endhighlight %}
{% endtabs %}

![Timebreak](images/timebreak.png)

## Time break template

> Refer to the [Templates](./templates#time-break-template) section for more details about the Time break template.