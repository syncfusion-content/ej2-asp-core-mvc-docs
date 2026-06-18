---
layout: post
title: Chain of Thoughts in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Chain of Thoughts in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Assist view
publishingplatform: ##Platform_Name##
documentation: ug
---
 
# Chain of Thoughts in ##Platform_Name## AI AssistView control
 
The AI AssistView provides support for rendering **Chain of Thoughts** (also called *Thinking* blocks), which allows you to visualize the AI model's reasoning process step by step before the final response is generated. It is especially useful for extended-thinking models (such as Claude 3.5, GPT-o1, and similar) that expose intermediate reasoning stages.
 
## Types of response blocks

A single response may contain `Thinking`, `Text`, and `tool` blocks in the `blocks` array. The component renders them in the order they appear. Below are the available types of the response blocks.

| Property | Description |
|---|---|---|---|
| `TextBlock` | Unique identifier for the block, used for collapsing/expanding state. |
| `ToolBlock` | Identifies this block as a thinking block. Required. |
| `ThinkingBlock` | Heading text shown in the collapsible header. |

## Configure the thinking block
 
You can use the block type as `Thinking` to the `blocks` array of the `addPromptResponse` method to push blocks (including thinking blocks) into the component at runtime. Pass an object with a `blocks` array, and set the second argument (`isFinalUpdate`) to `false` while streaming and `true` for the last update. It can be configured by using the below available properties.

You can use the `Thinking` block type in the blocks array of the addPromptResponse method to dynamically push blocks (including thinking blocks) into the component at runtime. Pass an object containing a blocks array, and set the second argument (isFinalUpdate) to false during streaming and true for the final update.

> When only `blocks` are provided (no `response` text), the component will render the blocks directly and skip the default text-response rendering path. When both `blocks` and `response` are supplied, the blocks are rendered first followed by the response text.
 
| Property | Type | Default | Description |
|---|---|---|---|
| `id` | `string` | auto-generated | Unique identifier for the block, used for collapsing/expanding state. |
| `blockType` | `'thinking'` | — | Identifies this block as a thinking block. Required. |
| `title` | `string` | `'Thinking...'` | Heading text shown in the collapsible header. |
| `content` | `string` | — | Markdown text rendered as a description beneath the stages. |
| `isActive` | `boolean` | `false` | When `true`, a Syncfusion spinner is shown inside the thinking header to indicate the reasoning is still in progress. |
| `collapsed` | `boolean` | `true` | Initial collapsed state of the thinking block. |
| `collapsible` | `boolean` | `true` | Whether the block can be expanded or collapsed by the user. |
| `stages` | `ThinkingStage[]` | — | Array of reasoning stages rendered using the Timeline component. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/basic/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Basic.cs" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/basic/basic.cs %}
{% endhighlight %}
{% endtabs %}
 
### Adding stages
 
Each entry in the `stages` array represents a single reasoning step. Below are the list of available stages property.
 
| Property | Type | Description |
|---|---|---|
| `id` | `string` | Unique identifier for the stage. |
| `content` | `string` | Markdown content for this stage. Supports `{index}` placeholders for inline context items. |
| `status` | `'completed'` \| `'inprogress'` \| `'failed'` | Controls the icon/spinner shown on the timeline dot. |
| `iconCss` | `string` | Custom CSS class for the timeline dot icon, overrides the default status icon. |
| `editableContext` | `ThinkingContextItem[]` | Inline context items injected into the stage content via `{index}` placeholders. |
 
#### Adding stage status
 
Each thinking stage will carry a `status` value that controls the visual indicator on its timeline dot:
 
- **`completed`** — renders a check icon (`e-check`).
- **`inprogress`** — renders an animated spinner.
- **`failed`** — renders an error/cross icon (`e-error-treeview`).

Use this to reflect real-time reasoning progress when streaming multi-step responses.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/stages-status/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Stages-Status.cs" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/stages-status/stages-status.cs %}
{% endhighlight %}
{% endtabs %}
 
#### Adding context items
 
The thinking stages support **inline context items** named, optionally clickable badges that appear inline within the stage content. They are defined in the `editableContext` array of a `ThinkingStage` and are injected into the `content` string using `{index}` placeholders, where `index` is the zero-based position in the `editableContext` array.
 
Each context item is described by the below available `ThinkingContextItem` properties:
 
| Property | Type | Description |
|---|---|---|
| `name` | `string` | Display label of the context badge. |
| `type` | `'file'` \| `'variable'` \| `'search'` \| `'tool'` \| `'result'` \| `'context'` | Determines the badge icon and CSS class. |
| `tooltipText` | `string` | Tooltip shown on hover. |
| `clickable` | `boolean` | When `true`, clicking the badge fires the `editableContextClicked` event. |
| `badge` | `ThinkingContextBadge` | Status badge appended to the item: `'success'`, `'warning'`, `'failed'`, `'pending'`, `'info'`, or `'none'`. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/editable-context/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Editable-Context.cs" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/editable-context/editable-context.cs %}
{% endhighlight %}
{% endtabs %}
 
### Configure editableContextClicked
 
The `editableContextClicked` event fires when a user clicks on an inline context item whose `clickable` property is `true`. Use this event to open a file preview, navigate to a source, or perform any custom action.
 
| Event argument | Type | Description |
|---|---|---|
| `event` | `Event` | The underlying browser click event. |
| `contextItem` | `ThinkingContextItem` | The context item that was clicked, including all its configured properties. |
 
```ts
aiAssistView.editableContextClicked = (args) => {
    if (args.contextItem.type === 'file') {
        openFilePreview(args.contextItem.name);
    }
};
```
 
## Configure thinking block template
 
You can use the `blockTemplate` property, to customize the thinking block rendering. The template receives a context object with the following properties:
 
| Context property | Type | Description |
|---|---|---|
| `block` | `ThinkingBlock` | The full thinking block model. |
| `blockIndex` | `number` | Zero-based index of this block in the `blocks` array. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/block-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Block-Template.cs" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/block-template/block-template.cs %}
{% endhighlight %}
{% endtabs %}
 
> When `blockTemplate` is set, the default collapsible header, spinner, and Timeline rendering are completely replaced by your template. Collapse/expand behaviour and spinner lifecycle management must be handled within the template itself.
 
## Configure item template

You can use the `itemTemplate` property to add individual thinking stages inside the Timeline. This property applies to every stage item within all thinking blocks.

The template context for each stage item exposes:

| Property | Description |
|---|---|
| `item` | Contains `content`, `cssClass`, `disabled`, `dotCss`, and `oppositeContent` properties of the timeline stage item. |
| `itemIndex` | Current item index in the timeline. |

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/item-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Item-Template.cs" %}
{% include code-snippet/ai-assistview/chain-of-thoughts/item-template/item-template.cs %}
{% endhighlight %}
{% endtabs %}