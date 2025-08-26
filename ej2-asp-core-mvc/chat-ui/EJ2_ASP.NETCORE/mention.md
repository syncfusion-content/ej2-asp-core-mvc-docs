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

The Syncfusion ChatUI allows users to mention others in messages using the `@` character, with an dropdown for selecting users. The following sections explain how to configure mentions

## Configure mention users
You can use the [mentionUsers](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_mentionUsers) property to define an array of users for the mention suggestion popup.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/mention/mention-user/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="mention-user.cs" %}
{% include code-snippet/chat-ui/mention/mention-user/mention-user.cs %}
{% endhighlight %}
{% endtabs %}

![Mention-User](images/MentionUsers.png)


## Customize the mention trigger character

You can use the [mentionTriggerChar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_mentionTriggerChar) property to customize the character which triggers the mention popup. The default value is `@`.


{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/mention/mention-trigger/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="mention-trigger.cs" %}
{% include code-snippet/chat-ui/mention/mention-trigger/mention-trigger.cs %}
{% endhighlight %}
{% endtabs %}

![mention-trigger](images/MentionCharacter.png)

## Predefine mentions with messages

You can use the [text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUIMessage.html#Syncfusion_EJ2_InteractiveChat_ChatUIMessage_Text) property in the [ChatUIMessage](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUIMessage.html#Syncfusion_EJ2_InteractiveChat_ChatUIMessage) to include predefined mentions in chat messages. The mentions field stores the selected users for each message.

> The `mentionUsers` property in a message contains a list of users, mapped by their order where the placeholder {0} is replaced by the first user, {1} by the second, and so on, automatically generating mentions in the user interface. If a placeholder's index is negative or exceeds the bounds of the mentionUsers array (e.g., using {5} with only two users), the mapping for that placeholder fails, and the placeholder text itself (e.g., {5}) is displayed in the final message.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/mention/mention-message/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="mention-message.cs" %}
{% include code-snippet/chat-ui/mention/mention-message/mention-message.cs %}
{% endhighlight %}
{% endtabs %}

![ScrollToBottom](images/MentionMessage.png)

## Configure mentionSelect

You can use the [mentionSelect](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_mentionSelect) event which triggers when a user selects an item from the mention dropdown, providing access to the selected user’s details for custom handling.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/mention/mention-select/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="mention-select.cs" %}
{% include code-snippet/chat-ui/mention/mention-select/mention-select.cs %}
{% endhighlight %}
{% endtabs %}