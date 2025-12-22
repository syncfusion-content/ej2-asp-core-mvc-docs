----
layout: post
title: Configure AI Assist in ###Platform_Name## Syncfusion Rich Text Editor
description: Learn about the AI Assistant feature in the Syncfusion Essential JS 2 ##Platform_Name## Rich Text Editor Component.
platform: ej2-asp-core-mvc
control: Properties of the AI Assistant
publishingplatform: ##Platform_Name##
documentation: ug
----

# Properties of AI Assistant

The `AIAssistantSettings` class provides the following properties for complete customization:

| Property | Type | Default | Description |
|----------|------|---------|-------------|
| `commands` | `AICommands[]` | Predefined commands | Defines the predefined AI command options displayed in the command dropdown menu. |
| `PopupMaxHeight` | `string \| number` | `'400px'` | Sets the maximum height of the AI Assistant popup. Accepts CSS height values or numbers (treated as pixels). |
| `PopupWidth` | `string \| number` | `'600px'` | Sets the width of the AI Assistant popup. Accepts CSS width values or numbers (treated as pixels). |
| `Placeholder` | `string` | `'Ask AI to rewrite or generate content.'` | Specifies the placeholder text shown in the AI prompt textarea. |
| `HeaderToolbarSettings` | `(AssitantHeaderToolbarItems \| IAIAssistantToolbarItem)[]` | `['AIcommands', 'Close']` | Configures the toolbar in the header section of the AI Assistant interface. |
| `PromptToolbarSettings` | `(AssistantPromptToolbarItems \| IAIAssistantToolbarItem)[]` | `['Edit', 'Copy']` | Configures the toolbar in the prompt editor (user input) section. |
| `ResponseToolbarSettings` | `(AssistantResponseToolbarItems \| IAIAssistantToolbarItem)[]` | `['Regenerate', 'Copy', '\|', 'Insert']` | Configures the toolbar in the AI response viewer section. |
| `Prompts` | `PromptModel[]` | `[]` | Defines the collection of predefined prompts and their corresponding responses. |
| `Suggestions` | `string[]` | `[]` | Defines suggestion prompts displayed to the user as guidance. |
| `BannerTemplate` | `string \| Function` | `''` | Specifies the template for the banner in the AI Assistant component. |
| `MaxPromptHistory` | `number` | `20` | Defines the maximum number of prompts that can be stored in the editor's history stack. |

The `AiAssistantSettings` property of the Rich Text Editor allows you to configure the following:

* AI Commands Dropdown menu items
* Preloaded conversations and suggestions in the AI Assistant
* AI Assistant popup height and width
* AI Assistant banner configuration
* Maximum length of prompt history
* Additional toolbar items in the AI Assistant Header, Prompt, and Response sections

## Adding items to the AI Commands Dropdown menu

To configure the items displayed in the AI Commands Dropdown menu, the `Commands` property of the `AiAssistantSettings` can be used. The commands come with predefined prompts for writing, summarizing, and translating content. The `Commands` property can be configured to add items or nested items to the dropdown menu.

**Example**

In the below example, a set of prompts and texts are configured to demonstrate the commands property usage.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/commands/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/commands/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/ai-assistant/commands/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Preloading Prompts, Response and Suggestions

To preload conversations and add suggested prompts to the AI Assistant use the `Prompts` and `Suggestions` properties of the `AiAssistantSettings`. This is helpful when conversation history needs to be loaded for a returning user, or to load the AI Assistant with default prompts for a new user.

**Example**

In the below sample, the `Prompts` and `Suggestions` properties of the `AiAssistantSettings` are used to preload the prompts, responses, and suggestions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/prompts/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/prompts/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/ai-assistant/prompts/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Header, Prompt and Response Toolbar

To configure the item order and add custom items to the header, prompt, and response sections, use the `HeaderToolbarSettings`, `PromptToolbarSettings`, and `ResponseToolbarSettings` properties of the `AiAssistantSettings`.

### Available Toolbar Items

The following table lists the available toolbar items for the Header, Prompt, and Response toolbars:

| Toolbar | Items & Their Use |
|---------|-------------------|
| **Header** | **AIcommands** – Opens AI-related command options.<br>**Close** – Closes the current panel or window. <br> **Clear** - Clear the current conversations. |
| **Prompt** | **Edit** – Allows you to modify the prompt text.<br>**Copy** – Copies the prompt to your clipboard. |
| **Response** | **Regenerate** – Produces a new response for the same prompt.<br>**Copy** – Copies the AI response.<br>**\|** – Visual separator between actions.<br>**Insert** – Inserts the generated response into the target editor or field. |

### Default Toolbar Items

The default toolbar configurations are:

- **Header Toolbar**: `['AIcommands', 'Close']`
- **Prompt Toolbar**: `['Edit', 'Copy']`
- **Response Toolbar**: `['Regenerate', 'Copy', '|', 'Insert']`

**Example**

In the below sample, the toolbar settings are configured to modify the order and items are displayed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/toolbar-settings/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/toolbar-settings/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/ai-assistant/toolbar-settings/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Popup Dimensions

To customize the dimensions of the AI Assistant popup based on the editor width, use the `PopupWidth` and `PopupMaxHeight` properties of the `AiAssistantSettings`. The default minimum height of the popup is `100px`, and the `PopupMaxHeight` property customizes the maximum height of the popup up to which the content can grow.

**Example**

In the below sample, the popup width and maximum height are configured.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/popup-dimensions/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/popup-dimensions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/ai-assistant/popup-dimensions/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Setting Maximum Conversation History Length

To set the maximum conversation history length, use the `MaxPromptHistory` property of the `AiAssistantSettings`. The default amount of conversation that can be loaded is `20` prompts. The conversation will be cleared when closing the popup. To retrieve all conversation history, use the `getAIPromptHistory()` method. This method is useful for loading previous conversations and populating the `Prompts` property when you need to restore or display earlier chat sessions.

**Example**
In the below sample, the maximum prompt history is configured to `30`, and when a save button is clicked the conversation history is retrieved using the `getAIPromptHistory()` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/prompt-history/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/prompt-history/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/ai-assistant/prompt-history/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Setting the Banner

To set the banner content displayed on top of the AI Assistant popup, use the `BannerTemplate` property of the `AiAssistantSettings`. This can be used to display welcome messages, instructions, or other relevant information.

**Example**

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/banner/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/ai-assistant/banner/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/ai-assistant/banner/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}