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

You can use the `text` property to add message content for the user. Each message can be configured with options such as id, text, author, timestamp, and more.

### Define current user

You can use the `author` property to identify the current user of the chat. Each user can be configured with options such as id, user, avatarUrl, and more.

> You can use the `user` property to display the user name and `id` property is necessary to differentiate between the multiple users. 

#### Setting avatar URL

You can use the `avatarUrl` property to define the image URL’s for the user avatar. If no URL is provided, fallback initials of the first and last name from the user’s name will be used.  

#### Setting avatar background color

You can use the `avatarBgColor` property to set a specific background color for user avatars using hexadecimal values. If no color is set, a custom background color is set based on specified theme.

#### Setting CSS class

You can use the `cssClass` property to customize the appearance of the chat user. 

### Define timestamp

You can use the `timeStamp` property to indicate the date and time of each message being sent. By default it is set to the current date and time when the message is sent.

#### Setting timestamp format

You can use the `timeStampFormat` to display specific time format for the timestamp. The default format is `dd/MM/yyyy hh:mm a`, but this can be customized to meet different localization and display needs. 

### Define message status

You can use the status property to update the status for the message(e.g., sent, received, read). It helps in managing message delivery and read receipts within the chat interface. 

#### Setting icon CSS

You can use the `iconCss` property to update the styling of status icons associated with messages, aiding visual differentiation between statuses.

#### Setting text

You can use the `text` property to provide information about the messages through descriptive text, providing users with the context of the message.

#### Setting tooltip

You can use the `tooltip` property to provide information about the messages by tooltips while hovering the status icon, providing users with additional data upon hovering.

### Setting auto scroll

You can use the `autoScrollToBottom` property to automatically scroll the chats when a new message is received in a conversation. By default, the value is false, requires manual scrolling or the FAB button to quick access to the bottom of the view. 

- By default, it scrolls to bottom for each message being sent or when the scroll is maintained at the bottom in the chat, in order to prevent the automatic scroll for different user messages you can use the `autoScrollToBottom` property.