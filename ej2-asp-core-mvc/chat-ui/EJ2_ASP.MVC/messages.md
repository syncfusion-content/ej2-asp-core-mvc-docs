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

The Chat UI allows to add messages using the [Messages](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_Messages) property. The message collection stores all the messages being sent and received.

## Configuring messages

You can use the `Text` property to add message content for the user. Each message can be configured with options such as `Id`, `Text`, `Author`, `Timestamp` and more.

### Define current user

You can use the `Author` property to identify the current user of the chat. Each user can be configured with options such as [Id](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_Id), [User](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_User), [AvatarUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_AvatarUrl) and more.

> You can use the [User](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_User) property to display the user name and [Id](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_Id) property is necessary to differentiate between the multiple users. 

#### Setting avatar URL

You can use the [AvatarUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_AvatarUrl) property to define the image URL’s for the user avatar. If no URL is provided, fallback initials of the first and last name from the user’s name will be used.  

#### Setting avatar background color

You can use the [AvatarBgColor](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_AvatarBgColor) property to set a specific background color for user avatars using hexadecimal values. If no color is set, a custom background color is set based on specified theme.

#### Setting CSS class

You can use the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUIUser.html#Syncfusion_EJ2_InteractiveChat_ChatUIUser_CssClass) property to customize the appearance of the chat user. 

### Define timestamp

You can use the `TimeStamp` property to indicate the date and time of each message being sent. By default it is set to the current date and time when the message is sent.

#### Setting timestamp format

You can use the `TimeStampFormat` to display specific time format for the timestamp. The default format is `dd/MM/yyyy hh:mm a`, but this can be customized to meet different localization and display needs. 

### Define message status

You can use the `Status` property to update the status for the message(e.g., sent, received, read). It helps in managing message delivery and read receipts within the chat interface. 

#### Setting icon CSS

You can use the `IconCss` property to update the styling of status icons associated with messages, aiding visual differentiation between statuses.

#### Setting text

You can use the `Text` property to provide information about the messages through descriptive text, providing users with the context of the message.

#### Setting tooltip

You can use the `Tooltip` property to provide information about the messages by tooltips while hovering the status icon, providing users with additional data upon hovering.

### Setting auto scroll

You can use the [AutoScrollToBottom](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.ChatUI.html#Syncfusion_EJ2_InteractiveChat_ChatUI_AutoScrollToBottom) property to automatically scroll the chats when a new message is received in a conversation. By default, the value is false, requires manual scrolling or the FAB button to quick access to the bottom of the view. 

- By default, it scrolls to bottom for each message being sent or when the scroll is maintained at the bottom in the chat, in order to prevent the automatic scroll for different user messages you can use the `AutoScrollToBottom` property.