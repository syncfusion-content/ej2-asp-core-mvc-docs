---
layout: post
title: Blocks in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about Blocks with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Blocks in ##Platform_Name## Block Editor control

The Block Editor control enables you to create block-based content editing solution using various types of blocks. The `e-blocks` tag helper allows you to define and manage the content structure of your editor.

## Blocks

Blocks are the fundamental building elements of the Block Editor. Each block represents a distinct content unit such as a `paragraph`, `heading`, `list`, or specialized content like `code snippets` or `images`. The Block Editor organizes content as a collection of `e-block` tag helper, allowing for better structure and formatting options.

You can configure blocks with various properties such as `id`, `type`, `content`, `children` and more to create rich, structured editor.

## Block types

The Block Editor supports multiple block types. Each block type offers different formatting and functionality options:

| Built-in Block Types                    | Description                                       |
|-----------------------------------------|---------------------------------------------------|
| Paragraph                               | Default block type for regular text content.      |
| Heading1 to Heading4                    | Different levels of headings for document structure.|
| CheckList                               | Interactive to-do lists with checkable items.     |
| BulletList                              | Unordered lists with bullet points.               |
| NumberedList                            | Ordered lists with sequential numbering.          |
| Code                                    | Formatted code blocks with syntax highlighting.   |
| Quote                                   | Styled block for quotations.                      |
| Callout                                 | Highlighted block for important information.      |
| Divider                                 | Horizontal separator line.                        |
| ToggleParagraph and ToggleHeading1-4    | Collapsible content blocks.                       |
| Image                                   | Block for displaying images.                      |
| Template                                | Predefined custom templates.                      |

### Configure block type

The Block Editor supports several block types through the BlockType enum.
You can configure the type of each block using the `type` property. The block type determines the appearance and behavior of the content. By default, the block type is set to `Paragraph`.

### Configure paragraph block

You can render Paragraph blocks by setting the `type` property as `Paragraph`. Paragraph blocks are the most common type, used for regular text content. They provide standard text formatting options and serve as the default block type.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paragraph.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph.cs %}
{% endhighlight %}
{% endtabs %}

![Paragraph](images/block-paragraph.png)

### Configure heading block

You can render Heading blocks by setting the `type` property as `Heading1`, `Heading2`, `Heading3`, or `Heading4`. Heading blocks (Heading1 to Heading4) are used to create document titles and section headers of varying importance. These blocks help structure your content hierarchically, making it easier to read and navigate.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/heading-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Heading.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/heading-block/heading.cs %}
{% endhighlight %}
{% endtabs %}

![Heading Block](images/block-heading.png)

### Configure toggle blocks

You can render Toggle blocks by setting the `type` property as `ToggleParagraph` or `ToggleHeading1` to `ToggleHeading4`. Toggle blocks allow users to expand or collapse sections, providing a way to hide or show content as needed.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/toggle-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toggle.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/toggle-block/toggle.cs %}
{% endhighlight %}
{% endtabs %}

![Toggle Block](images/block-toggle.png)

### Configure list blocks

You can render List blocks by setting the `type` property as `BulletList`, `NumberedList`, or `Checklist`. Bullet lists and numbered lists are ideal for unordered and ordered items, respectively, while checklist blocks enable interactive to-do lists with checkable items.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/list-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/list-block/list.cs %}
{% endhighlight %}
{% endtabs %}

![List Block](images/block-list.png)

### Configure code block

You can render Code blocks by setting the `type` property as `Code`. By setting the `codeSettings` property, you can configure the languages available for syntax highlighting and the default language. The default language is 'javascript'.

> Refer to the [CodeSettings](#configure-code-settings) section for more details about the code settings.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/code-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Code.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/code-block/code.cs %}
{% endhighlight %}
{% endtabs %}

![Code Block](images/block-code.png)

### Configure quote block

You can render Quote blocks by setting the `type` property as `Quote`. Quote blocks are specially styled for quotations or excerpts.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/quote-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Quote.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/quote-block/quote.cs %}
{% endhighlight %}
{% endtabs %}

![Quote Block](images/block-quote.png)

### Configure callout block

You can render Callout blocks by setting the `type` property as `Callout`. They're useful for notes, warnings, or tips that require special attention.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/callout-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Callout.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/callout-block/callout.cs %}
{% endhighlight %}
{% endtabs %}

![Callout Block](images/block-callout.png)

### Configure divider block

Divider blocks insert horizontal lines that separate different sections of content. You can render Divider blocks by setting the `type` property as `Divider`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/divider-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Divider.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/divider-block/divider.cs %}
{% endhighlight %}
{% endtabs %}

![Divider Block](images/block-divider.png)

### Configure image block

You can render Image blocks by setting the `type` property as `Image`. By setting the `imageSettings` property, you can configure the image source, allowed file types, and display dimensions etc.

> Refer to the [ImageSettings](#configure-image-settings) section for more details about the image settings.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/image-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/image-block/image.cs %}
{% endhighlight %}
{% endtabs %}

### Adding template

You can render Template blocks by setting the `type` property as `Template`. Template blocks enable you to use predefined content structures or custom templates.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/template-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/template-block/template.cs %}
{% endhighlight %}
{% endtabs %}

![Template Block](images/block-template.png)

## Configure content

Content in the Block Editor is managed through the `content` property of `e-block` tag helper.

Each content can have properties like `id`, `type`, `content`, `styles`, and more to customize the appearance and behavior of your text.

### Setting content type

You can specify the type of content using the `type` property. The Block Editor supports several content types through the `ContentType` enum:

| Built-in Content Type  | Description                         |
|------------------------|-------------------------------------|
| Text                   | Represents plain text content.      |
| Link                   | Represents a hyperlink.             |
| Code                   | Represents a code snippet.          |
| Mention                | Represents a user mention.          |
| Label                  | Represents a label or tag.          |

By default, the content type is set to `Text`.

#### Configure text content

You can configure Text content by setting the type property to `Text`. The default content type is `Text`.

#### Configure hyperlink

You can configure hyperlink content by setting the type property to `Link` and providing the link details through the `linkSettings` property.

The `linkSettings` property allows you to specify the URL and whether the link should open in a new window.

> Refer to the [LinkSettings](#configure-link-settings) section for more details about the link settings.

#### Configure inline code

You can configure inline code content by setting the type property to `Code`. Code content is used for inline code snippets within regular text.

#### Configure mention

Mentions are references to users or entities that can be inserted into your content. You can configure mention content by setting the type property to `Mention`.

Mentions are typically triggered by the `@` character and are linked to the `users` collection defined in the Block Editor.

#### Configure Label

You can configure label content by setting the type property to `Label`.

By default, labels are triggered by the `$` character. You can customize the label settings using the `labelSettings` property to define the label items and trigger character.

> Refer to the [LabelSettings](#configuring-labelSettings) section for more details about the label settings.

### Setting content styles

The Block Editor allows you to customize the appearance of content using the `styles` property. This property provides rich formatting options to style your text and content elements.

The `styles` property supports the following formatting options:

| Style Property | Description | Default Value |
|---------------|-------------|---------------|
| bold | Makes the text bold | false |
| italic | Makes the text italicized | false |
| underline | Adds an underline to the text | false |
| strikethrough | Adds a line through the text | false |
| color | Sets the text color (HEX or RGBA format) | '' |
| bgColor | Sets the background color for the text | '' |
| superscript | Displays the text as superscript | false |
| subscript | Displays the text as subscript | false |
| uppercase | Converts the text to uppercase | false |
| lowercase | Converts the text to lowercase | false |
| custom | Adds custom CSS styles to the text | '' |

You can apply one or more of these styles to any content element for rich text formatting:

### Configure link settings

Link settings control the behavior and properties of hyperlinks in your content. You can configure link settings using the `linkSettings` property.

The `linkSettings` property supports the following options:

| Option       | Description                                                                 | Default Value |
|--------------|-----------------------------------------------------------------------------|---------------|
| url          | Specifies the URL of the link.                                          |       ''        |
| openInNewWindow    | Specifies whether the link should open in a new window/tab.           | false         |

## Configure indent

You can specify the indentation level of a block using the `indent` property. This property accepts a numeric value that determines how deeply a block is nested from the left margin.

By default, the `indent` property is set to `0`.

## Configure checked state

For blocks that support selection states such as `CheckList`, you can configure the checked state using the `isChecked` property.

By default, the `isChecked` property is set to `false`.

## Configure expanded state

You can control whether a block is expanded or collapsed using the `isExpanded` property. By default, this property is set to `false`, meaning the block will be collapsed initially. This setting is only applicable to Toggle blocks.

## Configure CSS class

You can apply custom styling to individual blocks using the `cssClass` property. This property accepts a string containing one or more CSS class names.

Custom CSS classes allow you to define specialized styling for specific blocks in your editor.

## Configure image settings

For Image blocks, you can configure various aspects using the `imageSettings` property. By using this property, you can set the image source, dimensions, save format, allowed file types, and more.

The `imageSettings` property supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| `src` | URL or data URI of the image | '' |
| `saveFormat` | Format to save the image ('Base64' or 'Blob') | 'Base64' |
| `allowedTypes` | Array of allowed file extensions | ['.jpg', '.jpeg', '.png'] |
| `width` | Width of the image (px or %) | '' |
| `height` | Height of the image (px or %) | '' |
| `minWidth` | Minimum width for resizing (px or string) | 40 |
| `maxWidth` | Maximum width for resizing (px or string) | '' |
| `minHeight` | Minimum height for resizing (px or string) | 40 |
| `maxHeight` | Maximum height for resizing (px or string) | '' |
| `altText` | Alternative text for the image | '' |
| `cssClass` | CSS class(es) to apply to the image | '' |
| `readOnly` | Prevents modification of the image | false |

These settings give you fine-grained control over how images appear and behave within your Block Editor.

## Configure code settings

For Code blocks, you can configure syntax highlighting and language options using the `codeSettings` property.

The `codeSettings` property supports the following options:

| Property | Description | Default Value |
|----------|-------------|---------------|
| languages | Array of language options for syntax highlighting | [] |
| defaultLanguage | The default language to use for syntax highlighting | 'javascript' |

Each language object in the `languages` array should have:
- `language`: The language value used for syntax highlighting
- `label`: The display name shown in the language selector

## Configuring label settings

The labelSettings property of the Block Editor provides options for configuring how labels work in your editor. It allows you to define the trigger character and available label items.

### Trigger Character configuration

You can use the triggerChar property to specify the character that will trigger the label suggestions popup while typing. The default trigger character is `$`.

### Label items configuration

The labelItems array allows you to define the available labels in your editor. Each label item can have the following properties:

| Property      | Description                                 |
|---------------|---------------------------------------------|
| `id`          | Unique identifier for the label             |
| `text`        | Display text for the label                  |
| `groupHeader` | Category/group name for organizing labels   |
| `labelColor`  | Background color of the label               |
| `iconCss`     | CSS class for an icon to display with label |

When users type the trigger character followed by text, a popup will appear showing matching label items from which they can select. The selected label will be inserted into the content as a Label content item.

#### Using labels with group headers

Labels with the same `groupHeader` value will be grouped together in the label selection popup:

## Configure template

The Block Editor allows you to use custom templates for specialized content using the `template` property. Templates can be defined as strings, functions, or HTML elements.

## Configure placeholder

You can configure placeholder text for block using the `placeholder` property. This text appears when the block is empty. The default placeholder for the paragraph block is `Write something or ‘/’ for commands.`.

## Configure children

The Block Editor supports hierarchical content structures through the `children` property. This property allows you to create nested blocks, which is applicable only for Callout and Toggle blocks.

Child blocks can be configured with all the same properties as top-level blocks.

### Configure parent id

For proper hierarchy, you should ensure that the `parentId` of each child block matches the `id` of its parent block. This structure helps maintain the nested relationships within the editor.
