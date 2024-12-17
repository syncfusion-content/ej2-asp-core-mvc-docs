---
layout: post
title: Load on-demand in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Load on-demand in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Load on-demand
publishingplatform: ##Platform_Name##
documentation: ug
---

# Load on-demand in ##Platform_Name## Chat UI control

You can use the [loadOnDemand](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_LoadOnDemand) property to load messages dynamically when the scroll reaches the top of the message list improving performance and reducing load times, particularly in long conversations. This ensures a smooth user experience by only fetching messages as needed rather than loading the entire conversation at once.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/loadOnDemand/tagHelper %}
{% endhighlight %}
{% endtabs %}

![LoadOnDemand](images/loadOnDemand.png)
