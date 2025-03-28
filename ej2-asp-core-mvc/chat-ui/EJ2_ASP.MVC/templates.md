---
layout: post
title: Templates in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Templates in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in ##Platform_Name## Chat UI control

The Chat UI control provides several templates for customizing the appearance of the empty conversation area, messages, typing indicator, and more. These templates provide flexibility for users to create a unique, personalized chat experience. 

## Empty chat template

You can use the [EmptyChatTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_EmptyChatTemplate) property to customize the chat interface when no messages are displayed. Personalized content, such as welcome messages or images, can be added to create an engaging and inviting experience for users starting a conversation.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/templates/emptyChatTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EmptyChatTemplate.cs" %}
{% include code-snippet/chat-ui/templates/emptyChatTemplate/defaultMessages.cs %}
{% endhighlight %}
{% endtabs %}

![EmptyChatTemplate](images/emptyChatTemplate.png)

## Message template

You can use the [MessageTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_MessageTemplate) property to customize the appearance and styling of each chat message. Modify text styling, layout, and other design elements to ensure a personalized chat experience. The template context includes `Message` and `Index` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/templates/messageTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MessageTemplate.cs" %}
{% include code-snippet/chat-ui/templates/messageTemplate/defaultMessages.cs %}
{% endhighlight %}
{% endtabs %}

![MessageTemplate](images/messageTemplate.png)

## Time break template

You can use the [TimeBreakTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_TimeBreakTemplate) property to customize the template, such as showing "Today," "Yesterday," or specific dates. This enhances conversation organization by clearly separating messages based on time, improving readability for the user. The template context includes `MessageDate`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/templates/timebreakTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TimebreakTemplate.cs" %}
{% include code-snippet/chat-ui/templates/timebreakTemplate/defaultMessages.cs %}
{% endhighlight %}
{% endtabs %}

![TimebreakTemplate](images/timebreakTemplate.png)

## Typing indicator template

You can use the [TypingUsersTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_TypingUsersTemplate) property to customize the display of users currently typing in the chat. It allows for styling and positioning of the typing indicator, enhancing the user experience. The template context includes `Users`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/templates/typingUsersTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TypingUsersTemplate.cs" %}
{% include code-snippet/chat-ui/templates/typingUsersTemplate/defaultMessages.cs %}
{% endhighlight %}
{% endtabs %}

![TypingUsersTemplate](images/typingUsersTemplate.png)

## Suggestion template

You can use the [SuggestionTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_SuggestionTemplate) property to customize the quick reply suggestions that appear above the input field. Templates here can help create visually appealing and functional suggestion layouts. The template context includes `Suggestions` and `Index` items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/templates/suggestionTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SuggestionTemplate.cs" %}
{% include code-snippet/chat-ui/templates/suggestionTemplate/defaultMessages.cs %}
{% endhighlight %}
{% endtabs %}

![SuggestionTemplate](images/suggestionTemplate.png)

## Footer template

You can use the [FooterTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_FooterTemplate) property to customize the default footer area and manage message send actions with a personalized design. This flexibility allows users to create unique footers that meet their specific needs.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/templates/footerTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FooterTemplate.cs" %}
{% include code-snippet/chat-ui/templates/footerTemplate/defaultMessages.cs %}
{% endhighlight %}
{% endtabs %}

![FooterTemplate](images/footerTemplate.png)
