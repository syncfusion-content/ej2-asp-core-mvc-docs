---
layout: post
title: Nested blocks in ASP.NET MVC Block Editor control | Syncfusion
description: Checkout and learn about Nested blocks with ASP.NET MVC Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Nested blocks in ASP.NET MVC Block Editor control

## Configure children

The Block Editor supports hierarchical content structures through the `children` property. This property can be achieved through `properties` property that allows you to create nested blocks, which is applicable only for Callout and Collapsible blocks.

Child blocks can be configured with all the same properties as top-level blocks.

## Configure parent id

To establish a clear parent-child relationship, the `parentId` in the `properties` of each child block must match the `id` of its parent block.

This structure is essential for maintaining nested relationships within the editor.

## Configure collapsible blocks

You can render Collapsible blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [CollapsibleParagraph](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_CollapsibleParagraph) or [CollapsibleHeading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_CollapsibleHeading). Collapsible blocks allow users to expand or collapse sections, providing a way to hide or show content as needed.

### Configure levels

You can configure the CollapsibleHeading using the property `level` inside the `properties` property . The levels can be varied from `level: 1` to `level: 4`.

### Configure expanded state

You can control whether a block is expanded or collapsed using the `isExpanded` in the `properties` property. By default, this property is set to `false`, meaning the block will be collapsed initially. This setting is only applicable to Collapsible blocks.

### Block type & properties

```typescript
    // Configuring CollapsibleHeading block
    new BlockModel
    {
        blockType = "CollapsibleHeading",
        properties = new
        {
                level=1,
                isExpanded = true,
                children = new List<BlockModel>(){ 
                    // your actions
                }
        }
    },
    // Configuring CollapsibleParagraph block
    new BlockModel
    {
        blockType = "CollapsibleParagraph",
        properties = new
        {
                isExpanded = false,
                children = new List<BlockModel>()
                {
                    // your actions
                }
        }
        }
```

The below sample demonstrates the configuration of [CollapsibleParagraph](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_CollapsibleParagraph) and [CollapsibleHeading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_CollapsibleHeading) blocks in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/children-types/toggle-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toggle.cs" %}
{% include code-snippet/block-editor/blocks/children-types/toggle-block/toggle.cs %}
{% endhighlight %}
{% endtabs %}

![Toggle Block](./../../images/block-toggle.png)

### Configure placeholder

You can configure placeholder text for block using the `placeholder` in the `properties` property. This text appears when the block is empty. The default placeholder for collapsible heading and collapsible paragraph is `Collapsible Heading{level}` and `Collapsible Paragraph` respectively.

```typescript
    // Configuring CollapsibleHeading block
    new BlockModel
    {
        blockType = "CollapsibleHeading",
        properties = new
        {
                level=1,
                isExpanded = true,
                placeholder = "collapsible heading"
        }
    },
    // Configuring CollapsibleParagraph block
    new BlockModel
    {
        blockType = "CollapsibleParagraph",
        properties = new
        {
                isExpanded = false,
                placeholder = "collapsible paragraph"
        }
        }
```

## Configure quote block

You can render Quote blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [Quote](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Quote). Quote blocks are specially styled for quotations or excerpts.

### Block type & properties

```typescript
// Adding Quote block
{
    blockType = "Quote",
    properties = new {
    children = new List<BlockModel>()
    {
        new BlockModel()
        {
                blockType = "Paragraph",
                content = new List<object>(){
                    new{
                        contentType = "Text",
                        content = ""
                    }
                }
        }
    }
    }
}
```

The below sample demonstrates the configuration of quote block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/children-types/quote-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Quote.cs" %}
{% include code-snippet/block-editor/blocks/children-types/quote-block/quote.cs %}
{% endhighlight %}
{% endtabs %}

![Quote Block](./../../images/block-quote.png)

### Configure placeholder

You can configure placeholder text for block using the `placeholder` in the `properties` property. This text appears when the block is empty. The default placeholder for quote block is `Write a quote`.

```typescript
// Adding placeholder value to blocktype
{
    blockType =  'Quote',
    properties = new { placeholder = "Quote" }
}
```

## Configure callout block

You can render Callout blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [Callout](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Callout). They're useful for notes, warnings, or tips that require special attention.

### Block type & properties

```typescript
// Adding callout block
  {
    blockType = "Callout",
    properties = new {
    children = new List<BlockModel>()
    {
            new BlockModel()
            {
                    blockType = "Paragraph",
                    content = new List<object>(){
                            new{
                                    contentType = "Text",
                                    content = "Important information: This is a callout block used to highlight important content"
                            }
                    }
            }
    }
    }
  }

```

The below sample demonstrates the configuration of callout block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/children-types/callout-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Callout.cs" %}
{% include code-snippet/block-editor/blocks/children-types/callout-block/callout.cs %}
{% endhighlight %}
{% endtabs %}

![Callout Block](./../../images/block-callout.png)
