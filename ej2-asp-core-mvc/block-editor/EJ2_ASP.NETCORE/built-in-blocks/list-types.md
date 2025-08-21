---
layout: post
title: Lists in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about List Blocks with ##Platform_Name## Block Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Lists in ##Platform_Name## Block Editor control

List blocks in the BlockEditor component are used to organize content into structured lists. You can render List blocks by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as `BulletList`, `NumberedList`, or `Checklist`. Bullet lists and numbered lists are ideal for unordered and ordered items, respectively, while checklist blocks enable interactive to-do lists with checkable items.

## Configure bullet list 

You can render Bullet List block by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as `BulletList`. This block type is used for unordered lists.

#### Type

```typescript
// Adding bulletlist block
{
    Type = BlockType.BulletList,
    Content = new List<object>()
    {
        new 
        {
            type = "Text",
            content = "Implement bulletlist"
        }
    }
}
```

### Configure placeholder

You can configure placeholder text for block using the [Placeholder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.Block.html#Syncfusion_EJ2_BlockEditor_Block_Placeholder) property. This text appears when the block is empty. The default placeholder for bullet list is  `Add item`.

```typescript
// Adding placeholder value 
{
    Type = BlockType.BulletList,
    Props = new { placeholder = "bulletlist" }
    Content = new List<object>()
    {
        new 
        {
            type = "Text",
            content = "Implement bulletlist"
        }
    }
}
```

## Configure numbered list

You can render Numbered List block by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as  `NumberedList`.This block type is used for ordered lists.

#### Type

```typescript
// Adding numberedlist block
{
    Type = BlockType.NumberedList,
    Content = new List<object>()
    {
        new 
        {
            type = "Text",
            content = "Implement numberlist"
        }
    }
}
```

### Configure placeholder

You can configure placeholder text for block using the [Placeholder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.Block.html#Syncfusion_EJ2_BlockEditor_Block_Placeholder) property. This text appears when the block is empty. The default placeholder for numbered list is  `Add item`.

```typescript
// Adding placeholder value 
{
    Type = BlockType.NumberList,
    Props = new { placeholder = "Numberlist" }
    Content = new List<object>()
    {
        new 
        {
            type = "Text",
            content = "Implement numberlist"
        }
    }
}
```

## Configure check list

You can render Check List block by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockType.html) property as `Checklist`. This block type is used for creating interactive to-do lists.

#### Type

```typescript
// Adding checklist block 
{
    Type = BlockType.Checklist,
    Content = new List<object>()
    {
        new 
        {
            type = "Text",
            content = "Implement checklist"
        }
    }
}
```

### Configure checked state

For blocks that support selection states such as `CheckList`, you can configure the checked state using the `props` property with [IsChecked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.Block.html#Syncfusion_EJ2_BlockEditor_Block_IsChecked).

By default, the [IsChecked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.Block.html#Syncfusion_EJ2_BlockEditor_Block_IsChecked) property is set to `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/isChecked/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="IsChecked.cs" %}
{% include code-snippet/block-editor/blocks/isChecked/ischecked.cs %}
{% endhighlight %}
{% endtabs %}

![Block isChecked](images/block-ischecked.png)

### Configure placeholder

You can configure placeholder text for block using the [Placeholder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.Block.html#Syncfusion_EJ2_BlockEditor_Block_Placeholder) property. This text appears when the block is empty. The default placeholder for check list is  `To Do`.

```typescript
// Adding placeholder value 
{
    Type = BlockType.Checklist,
    Props = new { placeholder = "Checklist" }
    Content = new List<object>()
    {
        new 
        {
            type = "Text",
            content = "Implement Checklist"
        }
    }
}
```

## Configure list blocks

Below example illustrates how to render the different types of list blocks in the Block Editor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/blocks/blockTypes/paragraph-block/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/block-editor/blocks/blockTypes/list-block/list.cs %}
{% endhighlight %}
{% endtabs %}

![List Block](images/block-list.png)