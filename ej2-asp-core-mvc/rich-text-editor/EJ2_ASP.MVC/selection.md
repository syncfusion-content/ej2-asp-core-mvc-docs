---
layout: post
title: Selection in Syncfusion ##Platform_Name## Rich Text Editor Component
description: Learn here all about Slider-Based Text Selection in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Slider-Based Text Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Selection in ##Platform_Name## Rich Text Editor Control

## Text selection

The Rich Text Editor supports character range-based text selection using the **Syncfusion Slider** control. This feature allows users to select a specific range of characters (e.g., 33–45) within the editor content, which is then automatically highlighted.

### Adding a Slider for character range selection

The Rich Text Editor can be integrated with the **Slider** control to enable precise character range-based text selection. The slider is configured in `range` type, allowing users to select a start and end index within the editor content. When the slider values change, the corresponding text range is highlighted automatically. 

This approach is particularly useful for scenarios where exact character-level selection is required for operations such as copying, formatting, or analysis.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@{
var sliderValue = new int[] { 0, 50 };
}

@Html.EJS().Slider("range").Value(sliderValue).Type(Syncfusion.EJ2.Inputs.SliderType.Range).Min(0).Max(400).Render()

{% endhighlight %}
{% endtabs %}

### Dynamic range adjustment based on content

When the editor is created, the actual length of the text content is calculated, and the slider’s maximum value is updated dynamically to match this length. This ensures that the slider range always reflects the current content size. The editor is also focused programmatically to make the selection visible, and an initial selection is applied based on the slider’s default values.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@Html.EJS().RichTextEditor("editor").Height("400px").ContentTemplate(@<text><p>The Syncfusion Rich Text Editor, a WYSIWYG (what you see is what you get) editor, is a user interface that allows you to create, edit, and format rich text content. You can try out a demo of this editor here. Key features: Provides IFRAME and DIV modes. Bulleted and numbered lists. Handles images, hyperlinks, videos, hyperlinks, uploads, etc. Contains undo/redo manager.</p></text>).Render()

<script>
    document.addEventListener('DOMContentLoaded', function () {
        editorObj = document.getElementById('editor').ej2_instances[0];
        rangeObj = document.getElementById('range').ej2_instances[0];

        editorObj.addEventListener('created', function () {
            const panel = editorObj.contentModule.getEditPanel();
            const realLength = panel.firstChild.firstChild.textContent.length;
            rangeObj.max = realLength;
            rangeObj.dataBind();
        });
    });
</script>

{% endhighlight %}
{% endtabs %}

### Precise selection using DOM range

The selection logic is implemented in the [Change](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.slider.html#Syncfusion_EJ2_Inputs_Slider_Change) event of the slider. It retrieves the start and end positions from the slider and ensures they are within valid bounds. The code then uses a helper function, `getTextNodeAtOffset()`, which employs a `TreeWalker` to traverse text nodes and locate the exact node and offset for the given character positions. 

A Range object is created using these offsets and applied to the current selection using the browser’s `Selection` API. This guarantees accurate highlighting even when the content spans multiple text nodes.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@{
var sliderValue = new int[] { 0, 50 };
}

@Html.EJS().Slider("range").Value(sliderValue).Type(Syncfusion.EJ2.Inputs.SliderType.Range).Min(0).Max(400).Change("onChange").Render()

<script>
    function onChange(args) {
        const [start, end] = args.value;
        const panel = editorObj.contentModule.getEditPanel();
        const maxLength = panel.textContent.length;

        // Ensure start and end are within valid bounds
        const safeStart = Math.min(start, maxLength);
        const safeEnd = Math.min(end, maxLength);

        // Find the text node and relative offset for both start and end
        const startInfo = getTextNodeAtOffset(panel, safeStart);
        const endInfo = getTextNodeAtOffset(panel, safeEnd);

        if (startInfo && endInfo) {
            const range = document.createRange();
            range.setStart(startInfo.node, startInfo.offset);
            range.setEnd(endInfo.node, endInfo.offset);
            const selection = window.getSelection();
            selection.removeAllRanges();
            selection.addRange(range);
        }
    }
</script>

{% endhighlight %}
{% endtabs %}

### Helper function for accurate offset calculation

The `getTextNodeAtOffset()` function uses a `TreeWalker` to traverse text nodes inside the editor and determine the exact node and offset for a given character index. This ensures that even complex content structures are handled correctly.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

<script>
    function getTextNodeAtOffset(root: Node, offset: number): { node: Text; offset: number } | null {
        let currentOffset = 0;
        const walker: TreeWalker = document.createTreeWalker(root, NodeFilter.SHOW_TEXT, null, false);
        while (walker.nextNode()) {
            const node = walker.currentNode as Text;
            const nodeLength = node.textContent.length;
            if (currentOffset + nodeLength >= offset) {
            return { node, offset: offset - currentOffset };
            }
            currentOffset += nodeLength;
        }
        return null;
    }
</script>

{% endhighlight %}
{% endtabs %}

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/selection/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/selection/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Node selection

Node selection allows users to programmatically select entire HTML elements (nodes) such as paragraphs, images, or tables within the Rich Text Editor. This is useful when you want to highlight or manipulate specific content blocks without relying on manual user selection.

The following example demonstrates how to select a paragraph node programmatically using the browser's native `Range` and `Selection` API.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/node-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/node-selection/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/node-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/node-selection/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Cell selection

Cell selection allows users to programmatically select specific table cells within the Rich Text Editor. This is useful for highlighting or manipulating content inside tables without requiring manual user interaction.

The following example demonstrates how to select a table cell programmatically using the browser's native `Range` and `Selection` APIs.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/cell-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/cell-selection/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/cell-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/cell-selection/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Select all content

To select all content within the Rich Text Editor, use the `selectAll` method. This method highlights all the text and elements inside the editor, allowing users to perform actions such as formatting or deleting the entire content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/select-all/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/select-all/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/select-all/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/select-all/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}