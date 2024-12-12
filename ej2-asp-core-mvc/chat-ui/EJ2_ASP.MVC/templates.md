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

You can use the `EmptyChatTemplate` property to customize the chat interface when no messages are displayed. Personalized content, such as welcome messages or images, can be added to create an engaging and inviting experience for users starting a conversation.

## Message template

You can use the `MessageTemplate` property to customize the appearance and styling of each chat message. Modify text styling, layout, and other design elements to ensure a personalized chat experience. The template context includes `Message` and `Index` items.

## Time break template

You can use the `TimeBreakTemplate` property to customize the template, such as showing "Today," "Yesterday," or specific dates. This enhances conversation organization by clearly separating messages based on time, improving readability for the user. The template context includes `MessageDate`.

## Typing indicator template

You can use the `TypingUsersTemplate` property to customize the display of users currently typing in the chat. It allows for styling and positioning of the typing indicator, enhancing the user experience. The template context includes `Users`.

## Suggestion template

You can use the `SuggestionTemplate` property to customize the quick reply suggestions that appear above the input field. Templates here can help create visually appealing and functional suggestion layouts. The template context includes `Suggestions` and `Index` items.

## Footer template

You can use the `FooterTemplate` property to customize the default footer area and manage message send actions with a personalized design. This flexibility allows users to create unique footers that meet their specific needs.
