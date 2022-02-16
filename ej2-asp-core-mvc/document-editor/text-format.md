---
layout: post
title: Text Format in ##Platform_Name## Document Editor Component
description: Learn here all about Text Format in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Text Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# Working with Text Formatting

Document editor supports several formatting options for text like bold, italic, font color, highlight color, and more. This section describes how to modify the formatting for selected text in detail.

## Bold

The bold formatting for selected text can be get or set by using the following sample code.

```typescript

//Gets the value for bold formatting of selected text.
let bold : boolean = documenteditor.selection.characterFormat.bold;
//Sets bold formatting for selected text.
documenteditor.selection.characterFormat.bold = true;

```

You can toggle the bold formatting based on existing value at selection. Refer to the following sample code.

```typescript
**documenteditor.editor.toggleBold();
```

## Italic

The Italic formatting for selected text can be get or set by using the following sample code.

```typescript
documenteditor.selection.characterFormat.italic= true|false;
```

You can toggle the Italic formatting based on existing value at selection. Refer to the following sample code.

```typescript
documenteditor.editor.toggleItalic();
```

## Underline property

The underline style for selected text can be get or set by using the following sample code.

```typescript
documenteditor.selection.characterFormat.underline='Single' | 'None';
```

You can toggle the underline style of selected text based on existing value at selection by specifying a value. Refer to the following sample code.

```typescript
documenteditor.editor.toggleUnderline('Single');
```

## Strikethrough property

The strikethrough style for selected text can be get or set by using the following sample code.

```typescript
documenteditor.selection.characterFormat.strikethrough='Single' | 'Normal';
```

You can toggle the strikethrough style of selected text based on existing value at selection by specifying a value. Refer to the following sample code.

```typescript
documenteditor.editor.toggleStrikethrough();
```

## Superscript property

The selected text can be made superscript by using the following sample code.

```typescript
documenteditor.selection.characterFormat.baselineAlignment='Superscript';
```

Toggle the selected text as superscript or normal using the following sample code.

```typescript
documenteditor.editor.toggleSuperscript();
```

## Subscript property

The selected text can be made subscript by using the following sample code.

```typescript
documenteditor.selection.characterFormat.baselineAlignment='Subscript';
```

Toggle the selected text as subscript or normal using the following sample code.

```typescript
documenteditor.editor.toggleSubscript();
```

You can make a subscript or superscript text as normal using the following code.

```typescript
documenteditor.selection.characterFormat.baselineAlignment='Normal';
```

## Size

The size of selected text can be get or set using the following code.

```typescript
documenteditor.selection.characterFormat.fontSize= 32;
```

## Color

The color of selected text can be get or set using the following code.

```typescript
documenteditor.selection.characterFormat.fontColor= 'Pink';
documenteditor.selection.characterFormat.fontColor= '#FFC0CB';
```

## Font

The font style of selected text can be get or set using the following sample code.

```typescript
documenteditor.selection.characterFormat.fontFamily= 'Arial';
```

## Highlight color

The highlight color of the selected text can be get or set using the following sample code.

```typescript
documenteditor.selection.characterFormat.highlightColor= 'Pink';
documenteditor.selection.characterFormat.highlightColor= '#FFC0CB';
```

## Toolbar with options for text formatting

Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/text-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text-format.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/text-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text-format.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## See Also

* [Feature modules](../../document-editor/feature-module/)
* [Font dialog](../../document-editor/dialog/#font-dialog)
* [Keyboard shortcuts](../../document-editor/keyboard-shortcut/)