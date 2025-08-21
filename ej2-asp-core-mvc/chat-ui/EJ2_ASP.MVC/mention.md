---
layout: post
title: Mention Integration in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Mention Integration in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Chat UI
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mention Integration in ##Platform_Name## Chat UI control

## Mention Integration in Syncfusion Chat UI

The Syncfusion ChatUI allows users to mention others in messages using the `@` character, with an autocomplete dropdown for selecting users. The following sections explain how to configure mentions

## Configure mention users
You can use the [mentionUsers](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_mentionUsers) property to define an array of users for the mention suggestion popup.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/mention/mention-user/razor %}
{% endhighlight %}
{% highlight c# tabtitle="mention-user.cs" %}
{% include code-snippet/chat-ui/mention/mention-user/mention-user.cs %}
{% endhighlight %}
{% endtabs %}

![mention-user](images/mention-user.png)

## Customize the mention trigger character

You can use the [mentionTriggerChar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_mentionTriggerChar) property to customize the character which triggers the mention popup. The default value is `@`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/mention/mention-trigger/razor %}
{% endhighlight %}
{% highlight c# tabtitle="mention-trigger.cs" %}
{% include code-snippet/chat-ui/mention/mention-trigger/mention-trigger.cs %}
{% endhighlight %}
{% endtabs %}

![mention-trigger](images/mention-trigger.png)

## Predefine mentions with messages

You can use the [text](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIMessage.html#Syncfusion_EJ2_InteractiveChat_ChatUIMessage_Text) property in the [ChatUIMessage](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIMessage.html#Syncfusion_EJ2_InteractiveChat_ChatUIMessage) to include predefined mentions in chat messages. The mentions field stores the selected users for each message.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/mention/mention-message/razor %}
{% endhighlight %}
{% highlight c# tabtitle="mention-message.cs" %}
{% include code-snippet/chat-ui/mention/mention-message/mention-message.cs %}
{% endhighlight %}
{% endtabs %}

![mention-message](images/mention-message.png)

## Configure mentionSelect

You can use the [mentionSelect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_mentionSelect) event which triggers when a user selects an item from the mention dropdown, providing access to the selected user’s details for custom handling.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/mention/mention-select/razor %}
{% endhighlight %}
{% highlight c# tabtitle="mention-message.cs" %}
{% include code-snippet/chat-ui/mention/mention-select/mention-select.cs %}
{% endhighlight %}
{% endtabs %}
