---
layout: post
title: Typography Blocks in ASP.NET MVC Block Editor control | Syncfusion
description: Checkout and learn about Typography Blocks with ASP.NET MVC Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Typography Blocks in ASP.NET MVC Block Editor control

Typography blocks are essential for organizing and presenting text-based content in your documents. The BlockEditor component supports various structural blocks—such as Paragraph, Heading, Collapsible Block, Divider, Quote, and Callout to help you format and structure content effectively.

## Configure paragraph block

You can render Paragraph blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [Paragraph](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Paragraph). Paragraph blocks are the most common type, used for regular text content. They provide standard text formatting options and serve as the default block type.

### BlockType  

```typescript
// Adding paragraph block
{
    blockType = 'Paragraph',
    content = new List<object>
    {
        new 
            {
                contentType = 'Text',
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

![Paragraph Block](../images/block-paragraph.png)

### Configure placeholder

You can configure placeholder text for block using the `placeholder` in the `properties` property. This text appears when the block is empty. The default placeholder for the paragraph block is `Write something or ‘/’ for commands.`.

### Block type & properties

```typescript
// Adding placeholder
 {
    blockType = 'Paragraph',
    properties = new { placeholder = "Start typing ..." }
}
```

The below sample demonstrates the configuration of placeholder in the Block Editor for the paragraph block.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/placeholder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Placeholder.cs" %}
{% include code-snippet/block-editor/blocks/placeholder/placeholder.cs %}
{% endhighlight %}
{% endtabs %}

![Block placeholder](../images/block-placeholder.png)

## Configure heading block

You can render Heading blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [Heading](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Heading). Heading blocks are used to create document titles and section headers of varying importance. These blocks help structure your content hierarchically, making it easier to read and navigate.

### Configure levels

You can configure the heading blocks using the property `level` in the `properties` property.
The heading level representing a title `level: 1`, heading `level: 2`, subheading `level: 3` and a subsection by `level: 4`.

### Block type & properties

```typescript
// Adding heading block
{
    blockType = "Heading",
    content = new List<object>
    {
        new { contentType = "Text", content = "Heading" }
    },
     // levels range from 1 to 4
    properties = new { level = 4 }
}
```

The below sample demonstrates the configuration of heading block in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Heading.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/heading-block/heading.cs %}
{% endhighlight %}
{% endtabs %}

![Heading Block](../images/block-heading.png)

### Configure placeholder

You can configure placeholder text for block using the `placeholder` in the `properties` property. This text appears when the block is empty. The default placeholder for heading block is `Heading{level}`.

### Block type & properties

```typescript
// Adding placeholder
 {
    blockType = 'Paragraph',
    properties = new {level = 4 , placeholder = "Heading block" }
}
```

## Configure divider block

Divider blocks insert horizontal lines that separate different sections of content. You can render Divider blocks by setting the [blockType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as [Divider](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html#Syncfusion_EJ2_BlockEditor_BlockType_Divider).

### BlockType 

```typescript
// Adding divider block
{
    blockType = "Divider"
},
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

![Divider Block](../images/block-divider.png)
