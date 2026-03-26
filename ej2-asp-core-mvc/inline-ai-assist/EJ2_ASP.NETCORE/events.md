---
layout: post
title: Events in ##Platform_Name## Inline AI Assist Control | Syncfusion
description: Checkout and learn about Events in Syncfusion ##Platform_Name## Inline AI Assist control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## Inline AI Assist control

This section describes the Inline AI Assist events that will be triggered when appropriate actions are performed. The following events are available in the Inline AI Assist control.

## created

The Inline AI Assist control triggers the [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_Created) event when the control rendering is completed.

```cshtml

<div class="container">
    <ejs-inlineaiassist id="inline-assist" created="onCreated"></ejs-inlineaiassist>
</div>

<script>
    function created() {
        // Your required actions here
    }
</script>

```

## promptRequest

The [promptRequest](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_PromptRequest) event is triggered when the prompt request is made in the Inline AI Assist control.

```cshtml

<div class="container">
    <ejs-inlineaiassist id="inline-assist" promptRequest="onPromptRequest"></ejs-inlineaiassist>
</div>

<script>
    function onPromptRequest() {
        // Your required actions here
    }
</script>

```

## open

The [open](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_Open) event is triggered when the Inline AI Assist popup is opened.

```cshtml

<div class="container">
    <ejs-inlineaiassist id="inline-assist" open="onOpen"></ejs-inlineaiassist>
</div>

<script>
    function onOpen() {
        // Your required actions here
    }
</script>

```

### close

The [close](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.InlineAIAssist.html#Syncfusion_EJ2_InteractiveChat_InlineAIAssist_Close) event is triggered when the Inline AI Assist popup is closed.

```cshtml

<div class="container">
    <ejs-inlineaiassist id="inline-assist" close="onClose"></ejs-inlineaiassist>
</div>

<script>
    function onClose() {
        // Your required actions here
    }
</script>

```