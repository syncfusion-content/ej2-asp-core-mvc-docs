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

The Chat UI control triggers the [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_Created) event when the control rendering is completed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/created/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Created.cs" %}
{% include code-snippet/chat-ui/events/created/created.cs %}
{% endhighlight %}
{% endtabs %}

## Sending message

The [MessageSend](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_MessageSend) event is triggered before sending a message in the Chat UI control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/messageSend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="MessageSend.cs" %}
{% include code-snippet/chat-ui/events/messageSend/messageSend.cs %}
{% endhighlight %}
{% endtabs %}

## User typing

The [UserTyping](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_UserTyping) event is triggered when the user is typing a message in the Chat UI control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/userTyping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UserTyping.cs" %}
{% include code-snippet/chat-ui/events/userTyping/userTyping.cs %}
{% endhighlight %}
{% endtabs %}

## Before attachment upload

The `BeforeAttachmentUpload` event is triggered before attached files begin uploading in the Chat UI.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/beforeAttachmentUpload/razor %}
{% endhighlight %}
{% highlight c# tabtitle="BeforeAttachmentUpload.cs" %}
{% include code-snippet/chat-ui/events/beforeAttachmentUpload/beforeAttachmentUpload.cs %}
{% endhighlight %}
{% endtabs %}

## Attachment upload success

The `AttachmentUploadSuccess` event is triggered when an attached file is successfully uploaded in the Chat UI.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/attachmentUploadSuccess/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AttachmentUploadSuccess.cs" %}
{% include code-snippet/chat-ui/events/attachmentUploadSuccess/attachmentUploadSuccess.cs %}
{% endhighlight %}
{% endtabs %}

## Attachment upload failure

The `AttachmentUploadFailure` event is triggered when an attached file upload fails in the Chat UI.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/attachmentUploadFailure/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AttachmentUploadFailure.cs" %}
{% include code-snippet/chat-ui/events/attachmentUploadFailure/attachmentUploadFailure.cs %}
{% endhighlight %}
{% endtabs %}

## Attachment removed

The `AttachmentRemoved` event is triggered when an attached file is removed from the Chat UI.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/attachmentRemoved/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AttachmentRemoved.cs" %}
{% include code-snippet/chat-ui/events/attachmentRemoved/attachmentRemoved.cs %}
{% endhighlight %}
{% endtabs %}

## Attachment click

The `AttachmentClick` event is triggered when an attached file is clicked in the Chat UI.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/events/attachmentClick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AttachmentClick.cs" %}
{% include code-snippet/chat-ui/events/attachmentClick/attachmentClick.cs %}
{% endhighlight %}
{% endtabs %}
