---
layout: post
title: Inline Content in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about Inline Content with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Inline Content  in ##Platform_Name## Block Editor control

Content in the Block Editor is managed through the [content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.Block.html#Syncfusion_EJ2_BlockEditor_Block_Content) property of blocks.

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

> By default, the content type is set to `Text`.

## Configure text content

You can configure Text content by setting the type property to `Text`. The default content type is `Text`.

#### Type 

```typescript
// Adding inline text
{
    Type =  BlockType.Paragraph,
    Content = new List<object>()
    {
        new 
        {
            type =  'Text',
            content = 'Inline Text'
        }
    }
}
```

## Configure inline code

You can configure inline code content by setting the type property to `Code`. Code content is used for inline code snippets within regular text.

#### Type

```typescript
// Adding inline code
{
    Type =  BlockType.Paragraph,
    Content = new List<object>()
    {
        new 
        {
            type = 'Code',
            content = 'Inline Code'
        }
    }
}
```

## Configure hyperlink

You can configure hyperlink content by setting the type property to `Link`. By setting the `Props` property, you can configure the url of the link and specifies the link should open in a new tab/window.

### Configure link properties

Link settings control the behavior and properties of hyperlinks in your content. You can configure link settings using the link [Props](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.Block.html)  property.

The link [Props](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.Block.html)  property supports the following options:

| Option       | Description                                                                 | Default Value |
|--------------|-----------------------------------------------------------------------------|---------------|
| url          | Specifies the URL of the link.                                          |       ''        |
| openInNewWindow    | Specifies whether the link should open in a new window/tab.           | false         |


#### Type & Props

```typescript
{
    Type =  BlockType.Paragraph,
    Content = new List<object>()
    {
        new 
        {
            type = 'Link',
            content = 'hyperlinks',
            props = {
                url = 'https =//ej2.syncfusion.com/documentation',
                openInNewWindow = true
            }
        }
    }
}
```

## Configure Label

You can render labels by setting the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.Block.html#Syncfusion_EJ2_BlockEditor_Block_Type) property as `Label`. Additionally, by configuring the `props` property, you can customize how labels behave in your editor. This setup allows you to define the trigger character and specify the available label items.

### Built-in items

The Block Editor comes with offers different built-in options. These include:

-   **Progress**: In-progress, On-hold, Done
-   **Priority**: High, Medium, Low

### Customize label

You can customize the labels by using the `props` property with type `Label`.

#### Type & Props

```typescript
// Adding inline label
{
    Type =  BlockType.Paragraph,
    Content = new List<object>()
    {
        new 
            {
                type = 'Label',
                props = {
                    lableId = 'Name of the label'
                }
            }
    }
}
```

#### Trigger Character configuration

You can use the `triggerChar` property to specify the character that will trigger the label suggestions popup while typing. The default trigger character is `$`.

#### Label items configuration

The `labelItems` array allows you to define the available labels in your editor. Each label item can have the following properties:

| Property    | Description                                 |
|-------------|---------------------------------------------|
| `id`          | Unique identifier for the label             |
| `text`        | Display text for the label                  |
| `groupHeader` | Category/group name for organizing labels   |
| `labelColor`  | Background color of the label               |
| `iconCss`  | CSS class for an icon to display with label |

When users type the trigger character followed by text, a popup will appear showing matching label items from which they can select. The selected label will be inserted into the content as a Label content item.

#### Using labels with group headers

Labels with the same `groupHeader` value will be grouped together in the label selection popup:

The below sample demonstrates the customization of labels in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/label-settings/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/block-editor/blocks/label-settings/label.cs %}
{% endhighlight %}
{% endtabs %}

![Block label-settings](images/block-label.png)

## Configure mention

Mentions are references to users or entities that can be inserted into your content. You can configure mention content by setting the type property to `Mention`.

Mentions are typically triggered by the `@` character and are linked to the `users` collection defined in the Block Editor.

#### Type

```typescript
// Adding inline code
{
    Type =  BlockType.Paragraph,
    Content = new List<object>()
    {
        new 
        {
            type = 'Mention',
            id = 'user1'
        }
    }
}
```

## Setting content styles

The Block Editor enables you to customize the appearance of Text, Link, and Code elements using the `styles` property. This property offers rich formatting options to enhance the visual presentation of these content types.

The `styles`property supports the following formatting options:

| Style Property | Description | Default Value |
|---------------|-------------|---------------|
| bold | Makes the text bold | false |
| italic | Makes the text italicized | false |
| underline | Adds an underline to the text | false |
| strikethrough | Adds a line through the text | false |
| color | Sets the text color (HEX or RGBA format) | '' |
| backgroundColor | Sets the background color for the text | '' |
| superscript | Displays the text as superscript | false |
| subscript | Displays the text as subscript | false |
| uppercase | Converts the text to uppercase | false |
| lowercase | Converts the text to lowercase | false |
| custom | Adds custom CSS styles to the text | '' |

You can apply one or more of these styles to any content element for rich text formatting