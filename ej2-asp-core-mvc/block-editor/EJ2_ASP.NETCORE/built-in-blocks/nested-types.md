---
layout: post
title: Nested blocks in ASP.NET Core Block Editor control | Syncfusion
description: Checkout and learn about Nested blocks with ASP.NET Core Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Nested blocks in ASP.NET Core Block Editor control

## Configure children

The Block Editor supports hierarchical content structures through the `children` property. This property can be achieved through `properties` property that allows you to create nested blocks, which is applicable only for Callout and Collapsible blocks.

Child blocks can be configured with all the same properties as top-level blocks.

## Configure parent id

To establish a clear parent-child relationship, the `parentId` in the `properties` of each child block must match the `id` of its parent block.

This structure is essential for maintaining nested relationships within the editor.

## Configure collapsible blocks

You can render Collapsible blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [CollapsibleParagraph](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_CollapsibleParagraph) or [CollapsibleHeading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_CollapsibleHeading). Collapsible blocks allow users to expand or collapse sections, providing a way to hide or show content as needed.

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

The below sample demonstrates the configuration of collapsibleHeading and collapsibleParagraph blocks in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Toggle.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/toggle-block/toggle.cs %}
{% endhighlight %}
{% endtabs %}

![Toggle Block](./../../images/block-toggle.png)

### Configure placeholder

You can configure placeholder text for block using the `placeholder` in the `properties` property. This text appears when the block is empty. The default placeholder for collapsible heading and collapsible paragraph is [CollapsibleParagraph](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_CollapsibleParagraph) and [CollapsibleHeading](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_CollapsibleHeading) respectively.

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


The Block Editor allows you to use custom templates for specialized content using the [template](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Template) property. Templates can be defined as strings, functions, or HTML elements.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/template-block/template.cs %}
{% endhighlight %}
{% endtabs %}

![Template Block](./../../images/block-template.png)

## Configure quote block

You can render Quote blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [Quote](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Quote). Quote blocks are specially styled for quotations or excerpts.

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
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Quote.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/quote-block/quote.cs %}
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

You can render Callout blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [Callout](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Callout). They're useful for notes, warnings, or tips that require special attention.

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
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Callout.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/callout-block/callout.cs %}
{% endhighlight %}
{% endtabs %}

![Callout Block](./../../images/block-callout.png)
