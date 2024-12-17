---
layout: post
title: Typing indicator in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Typing indicator in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Typing indicator
publishingplatform: ##Platform_Name##
documentation: ug
---

# Typing indicator in ##Platform_Name## Chat UI control

## Show or hide typing indicator

You can use the [typingUsers](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_TypingUsers) property to display the current user’s who are typing to indicate the active participants typing response within the chat conversations. If the property is empty the typing indicators will be removed.

The typing users are the [UserModel](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html) list, where you can update the user’s dynamically to display the current typing user. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/typingUsers/tagHelper %}
{% endhighlight %}
{% endtabs %}

![TypingUsers](images/typingUsers.png)

## Typing indicator template 

> Refer to the [Templates](./templates#typing-indicator-template) section for more details about the Typing indicator template.