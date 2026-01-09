---
layout: post
title: Customize AI in ##Platform_Name## Syncfusion Rich Text Editor
description:  Learn about the AI Assistant customization in the Syncfusion Essential JS 2 ##Platform_Name Rich Text Editor component.
platform: ej2-asp-core-mvc
control: Customization of AI Assistant
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customization of AI Assistant

The AI Assistant feature is designed to be easily customizable using its properties, public methods, and events. The following examples demonstrate the customizations in the AI Assistant by adding custom toolbar buttons to the Prompt, Response, and Header toolbars, styling the AI Assistant popup, and using public methods to demonstrate a proofread use case.

## Custom Toolbar Buttons in AI Assistant

To add the custom toolbar items to the AI Assistant Header, Prompt, and Response toolbar, the `HeaderToolbarSettings`, `PromptToolbarSettings`, and `ResponseToolbarSettings` properties of the `AiAssistantSettings` can be used. The `AiAssistantToolbarClick` event allows you to execute custom logic when toolbar buttons are clicked.

The Custom items can be added to the `HeaderToolbarSettings`, `PromptToolbarSettings`, and `ResponseToolbarSettings` with the following properties.

| Property     | Description                                                                                                           |
| ------------ | --------------------------------------------------------------------------------------------------------------------- |
| `command`    | Specifies the primary command to execute when the toolbar item action is triggered.                                   |
| `subCommand` | Specifies the secondary or sub-command to execute when the toolbar item action is triggered.                          |
| `iconCss`    | Specifies the CSS class for the icon displayed in the toolbar item.                                                   |
| `text`       | Specifies the display text of the toolbar item.                                                                       |
| `type`       | Specifies the type of the toolbar item (default is `Button`).                                                         |
| `align`      | Specifies the alignment of the toolbar item within the toolbar (default is `Left`).                                   |
| `visible`    | Determines whether the toolbar item is visible (default is `true`).                                                   |
| `disabled`   | Determines whether the toolbar item is disabled and non-interactive (default is `false`).                             |
| `tooltip`    | Specifies the tooltip text shown when hovering over the toolbar item.                                                 |
| `cssClass`   | Specifies additional CSS classes applied to the toolbar item for styling.                                             |
| `template`   | Specifies a custom template for rendering the toolbar item; can be a string or a function depending on the framework. |
| `tabIndex`   | Specifies the tab order of the toolbar item for keyboard navigation (default is `-1`).                                |

**Example**

In the following example, **custom toolbar items** are added to the **Header**, **Prompt**, and **Response** toolbars of the AI Assistant, along with corresponding event handling logic.

1. **Custom Header Toolbar Item**

   * A **User Profile** dropdown is added as a custom header toolbar item using a template.
   * The **DropDownButton** component is dynamically initialized in the `BeforePopupOpen` event when the AI Assistant popup opens.
   * The dropdown instance is properly destroyed in the `BeforePopupClose` event to ensure clean resource management.

2. **Custom Prompt Toolbar Item**

   * A **Search in Google** toolbar button is added to the prompt toolbar.
   * When the button is clicked, the current prompt text is retrieved and used to open a new browser tab with the corresponding **Google search results**.

3. **Custom Response Toolbar Item**

   * A **Save** toolbar button is added to the response toolbar.
   * On clicking the button, the generated AI response content is extracted from the response container and can be processed further (for example, saving it to a database or local storage).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/custom-toolbar-items/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/custom-toolbar-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/ai-assistant/custom-toolbar-items/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Styling the Popup
The AI Assistant Popup can be styled by using the following css.

```css
.e-rte-aiquery-popup {
    padding:2px;
}
```

The AI Assistant Popup processing state can be styled by using the following css.

```css
.e-rte-aiquery-popup.processing {
    padding:2px;
    color: white;
    background: white;
    z-index: 1;
}
```

**Example**

In the following example, a CSS animation is applied to the popup while the request is in progress.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/popup-styling/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/popup-styling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/ai-assistant/popup-styling/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Use Case
Using the public methods, you can build custom workflows with the AI Assistant. Actions such as retrieving conversation history, executing prompts, adding responses, showing or hiding the AI Assistant, and clearing conversation history can all be achieved using the following public methods programmatically.

| **Method**                                                                       | **Description**                    |
| -------------------------------------------------------------------------------- | ---------------------------------- |
| `getAIPromptHistory()`                                                           | Get conversation history.          |
| `executeAIPrompt(prompt: string)`                                                | Send a prompt to the AI Assistant. |
| `addAIPromptResponse(outputResponse: string \| Object, isFinalUpdate?: boolean)` | Adds the Response to the AI Assistant.|
| `showAIAssistantPopup()`                                                         | Show the AI Assistant popup.       |
| `hideAIAssistantPopup()`                                                         | Hide the AI Assistant popup.       |
| `clearAIPromptHistory()`                                                         | Clear all conversation history.    |

**Example**

The following example demonstrates a Proofread use case by rendering a button outside the editor. On clicking the Proofread button:

1. Launches the AI Assistant popup using the `showAIAssistantPopup` method.
2. Executes a prompt using the `executeAIPrompt` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/usecase/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/usecase/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/ai-assistant/usecase/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}