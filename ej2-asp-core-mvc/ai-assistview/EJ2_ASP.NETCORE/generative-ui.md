---
layout: post
title: Generative UI in ##Platform_Name## AI AssistView control | Syncfusion
description: Checkout and learn about generative UI with ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: AI AssistView 
publishingplatform: ##Platform_Name##
documentation: ug
---

# Generative UI in ##Platform_Name## AI AssistView control

The `Generative UI` in AI AssistView allows you to render dynamic tools and UI elements within the AI AssistView. This enables seamless integration of interactive components based on AI-generated responses.

## Register tools

You can register custom tools using the [registerToolUI](../api/ai-assistview#registertoolui) method. It accepts tool name as string values, template and optional handler function. Tools are invoked by their name within block responses added through `addPromptResponse` method.

> **Note:** Use the blockType as `tool` and provide the tool name with the required properties through `props`. Tool should be registered before adding in responses and tool name should be unique.

### Configure tool template and handler

When registering a tool, you can configure how it appears by specifying a template and implement its behavior through a handler function. The template controls the UI layout, while the handler is provided with the container element and any additional actions needed to enable interactive functionality.

## Add tools in prompt responses

Use the [addPromptResponse](../api/ai-assistview#addpromptresponse) method to dynamically add tools to AI responses by passing the tool blocks in the response.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/generative-ui/add-tool-response/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GenerativeUI.cs" %}
{% include code-snippet/ai-assistview/generative-ui/add-tool-response/addtoolresponsecore.cs %}
{% endhighlight %}
{% endtabs %}

## Configure AI for generative UI responses

You can configure the AI service to return structured JSON blocks through `system prompt`. This ensures that AI-generated content is properly formatted and rendered as interactive tools or text blocks.

The following example demonstrates how to connect your AI service to generate and display dynamic UI components within the AI AssistView.

```cshtml
@model IndexModel
@using Syncfusion.EJ2.InteractiveChat

<div class="generative-ui-section">
    <ejs-aiassistview id="aiAssistView"
                      promptRequest="onPromptRequest"
                      created="onCreated">
    </ejs-aiassistview>
</div>

<script>
    var assistObj = null;

    var systemPrompt = `
        You are an AI assistant that generates Syncfusion AIAssistView blocks.

        Return ONLY valid JSON.

        Output format:
        {
            "blocks": [
                {
                    "blockType": "text",
                    "content": "Description"
                },
                {
                    "blockType": "tool",
                    "toolName": "toolname",
                    "props": { ... }
                }
            ]
        }
        Rules:
        1. Always return a single "blocks" array.
        2. Return ONLY valid JSON.
        3. You may return ANY number of blocks.
        4. Whenever weather-related queries are requested, invoke the weather-tool block with blockType "tool" and toolName "weather-tool".
    `;

    function onCreated() {
        assistObj = ej.base.getComponent(document.getElementById("aiAssistView"), "aiassistview");

        // Registering generative tool UI
        assistObj.registerToolUI({
            toolName: 'weather-tool',
            template: weatherTemplate
        });
    }

    function weatherTemplate(args) {
        return `<div tabindex="0" class="e-card" id="weather_card" role="button">
            <div class="e-card-header">
                <div class="e-card-header-caption">
                    <div class="e-card-header-title">${args.location}</div>
                    <div class="e-card-sub-title">${args.temperature}</div>
                </div>
            </div>
        </div>`;
    }

    async function onPromptRequest(args) {
        var apiKey = ''; // Your API key here
        var url = ''; // Your AI response URL here
        try {
            var response = await fetch(url, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                    'Authorization': 'Bearer ' + apiKey
                },
                body: JSON.stringify({
                    model: 'gpt-5',
                    messages: {
                        messages: [
                            { role: 'system', content: systemPrompt },
                            { role: 'user', content: args.prompt }
                        ]
                    },
                    max_output_tokens: 1000
                })
            });
            var reply = await response.json();
            var message = reply.output.find(function (item) { return item.type === 'message'; });
            var jsonText = (message && message.content && message.content[0] && message.content[0].text) || '{}';
            var aiData = JSON.parse(jsonText);
            assistObj.addPromptResponse({ blocks: aiData.blocks });
        } catch (error) {
            assistObj.addPromptResponse("We could not reach the AI service; please try again later.");
        }
    }
</script>
```

## See Also

* [About response blocks](./chain-of-thoughts.md)
