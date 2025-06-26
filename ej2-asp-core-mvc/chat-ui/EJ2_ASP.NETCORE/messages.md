---
layout: post
title: Messages in ##Platform_Name## Chat UI Control | Syncfusion
description: Checkout and learn about Messages in Syncfusion ##Platform_Name## Chat UI control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Messages
publishingplatform: ##Platform_Name##
documentation: ug
---

# Messages in ##Platform_Name## Chat UI control

The Chat UI allows to add messages using the `<e-chatui-message>` tag directive within the `<e-chatui-messages>` directive. The message collection stores all the messages being sent and received.

## Configuring messages

You can use the `text` property to add message content for the user. Each message can be configured with options such as `id`, `text`, `author`, `timestamp` and more.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/chat-ui/messages/text/text.cs %}
{% endhighlight %}
{% endtabs %}

![Text](images/text.png)

### Setting pinned

You can use the [isPinned](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_Pinned) property to highlight the important message in the chat. Once a message is pinned, you can access the options menu to continue the chat or unpin it.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/pinned/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pinned.cs" %}
{% include code-snippet/chat-ui/messages/pinned/pinned.cs %}
{% endhighlight %}
{% endtabs %}

![Pinned](images/pinned.png)

### Setting reply to

You can use the [replyTo](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_ReplyTo) property to respond to the original message preserving context and creating a threaded conversation.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/replyTo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReplyTo.cs" %}
{% include code-snippet/chat-ui/messages/replyTo/replyTo.cs %}
{% endhighlight %}
{% endtabs %}

![ReplyTo](images/replyTo.png)

### Setting forward

You can use the [isForwarded](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_Forward) property to specify the user when the message is forwarded.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/forwarded/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Forwarded.cs" %}
{% include code-snippet/chat-ui/messages/forwarded/forwarded.cs %}
{% endhighlight %}
{% endtabs %}

![Forwarded](images/forwarded.png)

### Setting compact mode

You can use the [enableCompactMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_StatusIconCss) property to align all messages to the left in the chat for creating a streamlined layout ideal for group conversations or space-constrained interfaces. By default, the value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/compact-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Compact-mode.cs" %}
{% include code-snippet/chat-ui/messages/compact-mode/compact-mode.cs %}
{% endhighlight %}
{% endtabs %}

![CompactMode](images/compact-mode.png)

### Define current user

You can use the `author` property to identify the current user of the chat. Each user can be configured with options such as `id`, `user`, `avatarUrl` and more.

> You can use the [user](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_User) property to display the user name and [id](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_Id) property is necessary to differentiate between the multiple users. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/user/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="User.cs" %}
{% include code-snippet/chat-ui/messages/user/user.cs %}
{% endhighlight %}
{% endtabs %}

![User](images/text.png)

#### Setting avatar URL

You can use the [avatarUrl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_AvatarUrl) property to define the image URL’s for the user avatar. If no URL is provided, fallback initials of the first and last name from the user’s name will be used.  

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/avatarUrl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AvatarUrl.cs" %}
{% include code-snippet/chat-ui/messages/avatarUrl/avatarUrl.cs %}
{% endhighlight %}
{% endtabs %}

![AvatarUrl](images/avatar-url.png)

#### Setting avatar background color

You can use the [avatarBgColor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_AvatarBgColor) property to set a specific background color for user avatars using hexadecimal values. If no color is set, a custom background color is set based on specified theme.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/avatarColor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AvatarColor.cs" %}
{% include code-snippet/chat-ui/messages/avatarColor/avatarColor.cs %}
{% endhighlight %}
{% endtabs %}

![AvatarBgColor](images/avatar-bgcolor.png)

#### Setting CSS class

You can use the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_CssClass) property to customize the appearance of the chat user. 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/avatarCssClass/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AvatarCssClass.cs" %}
{% include code-snippet/chat-ui/messages/avatarCssClass/avatarCssClass.cs %}
{% endhighlight %}
{% endtabs %}

![CssClass](images/avatar-cssclass.png)

#### Setting status icon css

You can use the `statusIconCss` property to identify the user's presence, including `online`, `offline`, `busy`, and `away` status in the Chat UI.

The following are the predefined status styles that can be defined using the `statusIconCss` property.

| Status | IconCss | 
| -------- | -------- | 
| `Available` | `e-user-online` |
| `Away` | `e-user-away` |
| `Busy` | `e-user-busy` |
| `Offline` | `e-user-offline` |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/statusIconCss/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="StatusIconCss.cs" %}
{% include code-snippet/chat-ui/messages/statusIconCss/statusIconCss.cs %}
{% endhighlight %}
{% endtabs %}

![StatusIconCss](images/statusIconCss.png)

### Define timestamp

You can use the `timeStamp` property to indicate the date and time of each message being sent. By default it is set to the current date and time when the message is sent.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/timestamp/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Timestamp.cs" %}
{% include code-snippet/chat-ui/messages/timestamp/timestamp.cs %}
{% endhighlight %}
{% endtabs %}

![TimeStamp](images/timestamp.png)

#### Setting timestamp format

You can use the `timeStampFormat` to display specific time format for the timestamp. The default format is `dd/MM/yyyy hh:mm a`, but this can be customized to meet different localization and display needs.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/timestampFormat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TimeStampFormat.cs" %}
{% include code-snippet/chat-ui/messages/timestampFormat/timestampFormat.cs %}
{% endhighlight %}
{% endtabs %}

![TimeStampFormat](images/timestampFormat.png)

### Define message status

You can use the status property to update the status for the message(e.g., sent, received, read). It helps in managing message delivery and read receipts within the chat interface. 

#### Setting icon CSS

You can use the `iconCss` property to update the styling of status icons associated with messages, aiding visual differentiation between statuses.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/statusIcon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="StatusIcon.cs" %}
{% include code-snippet/chat-ui/messages/statusIcon/statusIcon.cs %}
{% endhighlight %}
{% endtabs %}

![IconCss](images/status-icon.png)

#### Setting text

You can use the `text` property to provide information about the messages through descriptive text, providing users with the context of the message.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/statusText/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="StatusText.cs" %}
{% include code-snippet/chat-ui/messages/statusText/statusText.cs %}
{% endhighlight %}
{% endtabs %}

![Text](images/status-text.png)

#### Setting tooltip

You can use the `tooltip` property to provide information about the messages by tooltips while hovering the status icon, providing users with additional data upon hovering.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/statusTooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="StatusTooltip.cs" %}
{% include code-snippet/chat-ui/messages/statusTooltip/statusTooltip.cs %}
{% endhighlight %}
{% endtabs %}

![Tooltip](images/status-tooltip.png)

### Setting auto scroll

You can use the [autoScrollToBottom](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_AutoScrollToBottom) property to automatically scroll the chats when a new message is received in a conversation. By default, the value is false, requires manual scrolling or the FAB button to quick access to the bottom of the view. 

- By default, it scrolls to bottom for each message being sent or when the scroll is maintained at the bottom in the chat, in order to prevent the automatic scroll for different user messages you can use the `autoScrollToBottom` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/autoScroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AutoScroll.cs" %}
{% include code-snippet/chat-ui/messages/autoScroll/autoScroll.cs %}
{% endhighlight %}
{% endtabs %}

![AutoScrollToBottom](images/auto-scroll.png)

## Setting suggestions

You can use the [suggestions](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_Suggestions) property, to add the suggestions in both initial and on-demand which help users to quick-reply options above the input field.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/suggestion/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Suggestion.cs" %}
{% include code-snippet/chat-ui/messages/suggestion/defaultMessages.cs %}
{% endhighlight %}
{% endtabs %}

![Suggestion](images/suggestion.png)

## Configure message options

The `e-chatui-messagetoolbarsettings` tag helper allows customization of the message toolbar for richer chat experience in the Chat UI. It provides options to define the toolbar `width`, configure a set of toolbar `items`, and handle `itemClick` events for enhanced interactivity. By default, the message options available are `Copy`, `Reply`, `Pin`, and `Delete`.

### Copying a message

You can copy the message item to quickly duplicate the message, by using the toolbar copy icon in the message options.

### Deleting a message

You can delete a message item to remove it from the chat conversation, by using the toolbar trash icon in the message options.

### Setting width

You can use the `width` property to set width of the message toolbar in the chat. By default, the value is `100%`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Width.cs" %}
{% include code-snippet/chat-ui/messages/width/width.cs %}
{% endhighlight %}
{% endtabs %}

### Setting items

You can use the `items` property to specify the toolbar item in the message toolbar of the chat.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Items.cs" %}
{% include code-snippet/chat-ui/messages/items/items.cs %}
{% endhighlight %}
{% endtabs %}

![Items](images/items.png)

### Setting itemClick

You can use the `itemClicked` event when the toolbar item is clicked in the message toolbar of the chat.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chat-ui/messages/itemClicked/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ItemClicked.cs" %}
{% include code-snippet/chat-ui/messages/itemClicked/itemClicked.cs %}
{% endhighlight %}
{% endtabs %}