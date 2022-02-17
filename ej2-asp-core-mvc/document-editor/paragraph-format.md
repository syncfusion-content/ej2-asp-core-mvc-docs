---
layout: post
title: Paragraph Format in ##Platform_Name## Document Editor Component
description: Learn here all about Paragraph Format in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Paragraph Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# Working with Paragraph Formatting

Document editor supports various paragraph formatting options such as text alignment, indentation, paragraph spacing, and more.

## Indentation

You can modify the left or right indentation of selected paragraphs using the following sample code.

```typescript
documenteditor.selection.paragraphFormat.leftIndent= 24;
documenteditor.selection.paragraphFormat.rightIndent= 24;
```

## Special indentation

You can define special indent for first line of the paragraph using the following sample code.

```typescript
documenteditor.selection.paragraphFormat.firstLineIndent= 24;
```

## Increase indent

You can increase the left indent of selected paragraphs by a factor of 36 points using the following sample code.

```typescript
documenteditor.editor.increaseIndent()
```

## Decrease indent

You can decrease the left indent of selected paragraphs by a factor of 36 points using the following sample code.

```typescript
documenteditor.editor.decreaseIndent()
```

## Text alignment

You can get or set the text alignment of selected paragraphs using the following sample code.

```typescript
documenteditor.selection.paragraphFormat.textAlignment= 'Center' | 'Left' | 'Right' | 'Justify';
```

You can toggle the text alignment of selected paragraphs by specifying a value using the following sample code.

```typescript
documenteditor.editor.toggleTextAlignment('Center' | 'Left' | 'Right' | 'Justify');
```

## Line spacing and its type

You can define the line spacing and its type for selected paragraphs using the following sample code.

```typescript
documenteditor.selection.paragraphFormat.lineSpacingType='AtLeast';
documenteditor.selection.paragraphFormat.lineSpacing= 6;
```

## Paragraph spacing

You can define the spacing before or after the paragraph by using the following sample code.

```typescript
documenteditor.selection.paragraphFormat.beforeSpacing= 24;
documenteditor.selection.paragraphFormat.afterSpacing= 24;
```

## Pagination properties

You can enable or disable the following pagination properties for the paragraphs in a Word document.

* Widow/Orphan control - whether the first and last lines of the paragraph are to remain on the same page as the rest of the paragraph when paginating the document.
* Keep with next - whether the specified paragraph remains on the same page as the paragraph that follows it while paginating the document.
* Keep lines together - whether all lines in the specified paragraphs remain on the same page while paginating the document.

The following example code illustrates how to enable or disable these pagination properties for the selected paragraphs.

```typescript
documenteditor.selection.paragraphFormat.widowControl = false;
documenteditor.selection.paragraphFormat.keepWithNext = true;
documenteditor.selection.paragraphFormat.keepLinesTogether = true;
```

## Toolbar with paragraph formatting options

The following sample demonstrates the paragraph formatting options using a toolbar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/paragraph-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paragraph-format.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/paragraph-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paragraph-format.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## See Also

* [Feature modules](../../document-editor/feature-module/)
* [Paragraph dialog](../../document-editor/dialog/#paragraph-dialog)
* [Keyboard shortcuts](../../document-editor/keyboard-shortcut/)
