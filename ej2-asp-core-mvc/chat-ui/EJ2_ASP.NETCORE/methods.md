---
layout: post
title: Methods in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Methods in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Methods
publishingplatform: ##Platform_Name##
documentation: ug
---

# Methods in ##Platform_Name## Chat UI control

## Adding message

You can use the `addMessage` public method to add the messages in the Chat UI. You can add it either as a `string` or `MessageModel` collection. It programmatically adds a new message to the chat. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/methods/addMessageObj/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Adding New Message as Object](images/addMessageObj.png)

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/methods/addMessageString/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Adding New Message as string](images/addMessageString.png)

## Edit messages

You can use the `updateMessage` public method to update the messages in the ChatUI to modify an existing message within the chat, useful for editing or correcting sent messages.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/methods/editMessage/tagHelper %}
{% endhighlight %}
{% endtabs %}

![EditMessage](images/editMessage.png)

## Scroll to Bottom

You can use the `scrollToBottom` public method to scroll the chat view to the latest message, ensuring users see the new content updated.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/methods/scrollToBottom/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ScrollToBottom](images/scrollToBottom.png)
