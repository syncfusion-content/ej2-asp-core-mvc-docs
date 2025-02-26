---
layout: post
title: Events in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Events in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## Chat UI control

This section describes the Chat UI events that will be triggered when appropriate actions are performed. The following events are available in the Chat UI control.

## Created

The Chat UI control triggers the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_Created) event when the control rendering is completed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/created/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Created.cs" %}
{% include code-snippet/chat-ui/events/created/created.cs %}
{% endhighlight %}
{% endtabs %}

## Sending message

The [messageSend](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_MessageSend) event is triggered before sending a message in the Chat UI control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/messageSend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MessageSend.cs" %}
{% include code-snippet/chat-ui/events/messageSend/messageSend.cs %}
{% endhighlight %}
{% endtabs %}

## User typing

The [userTyping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_UserTyping) event is triggered when the user is typing a message in the Chat UI control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/userTyping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="UserTyping.cs" %}
{% include code-snippet/chat-ui/events/userTyping/userTyping.cs %}
{% endhighlight %}
{% endtabs %}
