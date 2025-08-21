---
layout: post
title: Typography Blocks in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about Typography Blocks with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Typography Blocks in ##Platform_Name## Block Editor control

Typography blocks are essential for organizing and presenting text-based content in your documents. The BlockEditor component supports various structural blocks—such as Paragraph, Heading, Collapsible Block, Divider, Quote, and Callout to help you format and structure content effectively.

## Configure paragraph block

You can render Paragraph blocks by setting the [type](../api/blockeditor/blockModel/#type) property as `Paragraph`. Paragraph blocks are the most common type, used for regular text content. They provide standard text formatting options and serve as the default block type.

#### Type 

```typescript
// Adding paragraph block
{
    Type = BlockType.Paragraph,
    Content = new List<object>()
    {
        new 
        {
            type = "Text",
            content = 'This is a paragraph block example.'
        }
    }
}
```

The below sample demonstrates the configuration of paragraph block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paragraph.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/paragraph.cs %}
{% endhighlight %}
{% endtabs %}

![Paragraph Block](images/block-paragraph.png)

### Configure placeholder

You can configure placeholder text for block using the [placeholder](../api/blockeditor/blockModel/#placeholder) property. This text appears when the block is empty. The default placeholder for the paragraph block is `Write something or ‘/’ for commands.`.

#### Type & Props

```typescript
// Adding placeholder
 {
    Type = BlockType.Paragraph,
    Props = new {placeholder: 'Start typing ...'}
}
```

The below sample demonstrates the configuration of paragraph block in the Block Editor.

The below sample demonstrates the configuration of placeholder in the Block Editor for the paragraph block.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/placeholder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Placeholder.cs" %}
{% include code-snippet/block-editor/blocks/placeholder/placeholder.cs %}
{% endhighlight %}
{% endtabs %}

![Block placeholder](images/block-placeholder.png)

## Configure heading block

You can render Heading blocks by setting the [type](../api/blockeditor/blockModel/#type) property as `Heading`. Heading blocks are used to create document titles and section headers of varying importance. These blocks help structure your content hierarchically, making it easier to read and navigate.

### Configure levels

You can configure the heading blocks using the property `level`.
The heading level representing a title `level: 1`, heading `level: 2`, subheading `level: 3` and a subsection by `level: 4`.

#### Type & Props

```typescript
// Adding heading block
{
    Type = BlockType.Heading,
    Props = new { level = 1 },
    // levels range from 1 to 4
    Content = new List<object>()
    {
        new 
        {
            type = "Text",
            content = 'This is a heading block example.'
        }
    }
}
```

The below sample demonstrates the configuration of paragraph block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Heading.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/heading-block/heading.cs %}
{% endhighlight %}
{% endtabs %}

![Heading Block](images/block-heading.png)

### Configure placeholder

You can configure placeholder text for block using the [placeholder](../api/blockeditor/blockModel/#placeholder) property. This text appears when the block is empty. The default placeholder for heading block is `Heading{levels}`.

```typescript
// Adding placeholder value to blocktype
{
    Type = BlockType.Heading,
    Props = new  { 
        level = 1,
        placeholder = 'Heading1'
    }
}
```

## Configure collapsible blocks

You can render Collapsible blocks by setting the [type](../api/blockeditor/blockModel/#type) property as `CollapsibleParagraph` or `CollapsibleHeading`. Collapsible blocks allow users to expand or collapse sections, providing a way to hide or show content as needed.

### Configure levels

You can configure the CollapsibleHeading using the property `level` inside the `props` property . The levels can be varied from `level: 1` to `level: 4`.

### Configure children

The Block Editor supports hierarchical content structures through the [children](../api/blockeditor/blockModel/#children) property. This property can be achieved through `props` property that allows you to create nested blocks, which is applicable only for Callout and Collapsible blocks.

Child blocks can be configured with all the same properties as top-level blocks.

### Configure expanded state

You can control whether a block is expanded or collapsed using the [isExpanded](../api/blockeditor/blockModel/#isexpanded) property. By default, this property is set to `false`, meaning the block will be collapsed initially. This setting is only applicable to Collapsible blocks.

#### Type & Props

```typescript
// Configuring CollapsibleHeading block
{
    Type = BlockType.CollapsibleHeading,
    Props= new
    {
        level=1,
        IsExpanded = true,
        Children = new List<Block>()   
            {
                //your content to be here..
            }
    }
}
// Configuring CollapsibleParagraph block
{
    Type = BlockType.CollapsibleParagraph,
    Props= new
    {
        Children = new List<Block>()   
            {
                //your content to be here..
            }
    }
}
```

The below sample demonstrates the configuration of collapsibleHeading and collapsibleParagraph blocks in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Toggle.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/toggle-block/toggle.cs %}
{% endhighlight %}
{% endtabs %}

![Toggle Block](images/block-toggle.png)

### Configure placeholder

You can configure placeholder text for block using the [placeholder](../api/blockeditor/blockModel/#placeholder) property. This text appears when the block is empty. The default placeholder for collapsible heading and collapsible paragraph is `Collapsible Heading{levels}` and `Collapsible Paragraph` respectively.

```typescript
// Adding placeholder value to collapsible heading
{
    Type = BlockType.CollapsibleHeading,
    Props= new
    {
        level=1,
        IsExpanded = true,
        placeholder = 'collapsible heading block',
    }
}
//Adding placeholder value for collapsible paragraph
{
    Type = BlockType.CollapsibleParagraph,
    Props= new
    {
        placeholder = 'collapsible paragraph block',
    }
}
```

## Configure divider block

Divider blocks insert horizontal lines that separate different sections of content. You can render Divider blocks by setting the [type](../api/blockeditor/blockModel/#type) property as `Divider`.

#### Type & Props

```typescript
// Adding divider block
{
    {
        Type = BlockType.Paragraph,
        Content = new List<object>()
        {
            new 
            {
                type = "Text",
                content = "This section discusses the features of the Block Editor."
            }
        }
    },
    {
        Type = BlockType.Divider
    },
    {
       Type = BlockType.Paragraph,
        Content = new List<object>()
        {
            new 
            {
                type = "Text",
                content = "This section discusses the features of the Block Editor."
            }
        }
    }
}
```

The below sample demonstrates the configuration of divider block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Divider.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/divider-block/divider.cs %}
{% endhighlight %}
{% endtabs %}

![Divider Block](images/block-divider.png)

## Configure quote block

You can render Quote blocks by setting the [type](../api/blockeditor/blockModel/#type) property as `Quote`. Quote blocks are specially styled for quotations or excerpts.

#### Type & Props

```typescript
// Adding quote block
{
    Type = BlockType.Quote,
    Content = new List<object>()
    {
        new 
        {
            type = "Text",
            content = "The greatest glory in living lies not in never falling, but in rising every time we fall."
        }
    }
}
```

The below sample demonstrates the configuration of quote block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Quote.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/quote-block/quote.cs %}
{% endhighlight %}
{% endtabs %}

![Quote Block](images/block-quote.png)

### Configure placeholder

You can configure placeholder text for block using the [placeholder](../api/blockeditor/blockModel/#placeholder) property. This text appears when the block is empty. The default placeholder for quote block is `Write a quote`.

```typescript
// Adding placeholder value to blocktype
{
    Type =  BlockType.Quote,
    Props = new  { placeholder = 'Quote'}
}
```

## Configure callout block

You can render Callout blocks by setting the [type](../api/blockeditor/blockModel/#type) property as `Callout`. They're useful for notes, warnings, or tips that require special attention.

#### Type & Props

```typescript
// Adding callout block
 {
    Type = BlockType.Callout,
    Props= new {
    Children = new List<Block>()
    {
        new Block()
        {
            Type = "Paragraph",
            Content = new List<object>(){
                new{
                        type = "Text",
                        content = "Important information: This is a callout block used to highlight important content."
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
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Callout.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/callout-block/callout.cs %}
{% endhighlight %}
{% endtabs %}

![Callout Block](images/block-callout.png)

### Configure children

The Block Editor supports hierarchical content structures through the [children](../api/blockeditor/blockModel/#children) property. This property allows you to create nested blocks, which is applicable only for Callout and Collapsible blocks.

Child blocks can be configured with all the same properties as top-level blocks.

### Configure parent id

For proper hierarchy, you should ensure that the [parentId](../api/blockeditor/blockModel/#parentid) of each child block matches the [id](../api/blockeditor/blockModel/#id) of its parent block. This structure helps maintain the nested relationships within the editor.

The below sample demonstrates the configuration of children in the Block Editor using parentId.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/children/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Children.cs" %}
{% include code-snippet/block-editor/blocks/children/children.cs %}
{% endhighlight %}
{% endtabs %}

![Block children](images/block-children.png)