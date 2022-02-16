---
layout: post
title: Styles in ##Platform_Name## Document Editor Component
description: Learn here all about Styles in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Styles
publishingplatform: ##Platform_Name##
documentation: ug
---


# Styles

Styles are useful for applying a set of formatting consistently throughout the document. In document editor, styles are created and added to a document programmatically or via the built-in Styles dialog.

## Styles definition overview

A Style in document editor should have the following properties:

* **name**: Name of the style. All styles in a document have a unique name, which is used as an identifier when applying the style.
* **type**: Specifies the document elements that the style will target. For example, paragraph or character.
* **next**: Specifies that the current style inherits the style set to this property. This is how hierarchical styles are defined.
* **link**: Provides a relation between the paragraph and character style.
* **characterFormat**: Specifies the properties of paragraph and character style.
* **paragraphFormat**: Specifies the properties of paragraph style.
* **basedOn**: Specifies that the current style inherits the style set to this property. This is how hierarchical styles are defined. It can be optional.

> The style type should match the inherited style type. For example, it is not possible to have a character style inherit a paragraph style.

## Default style

The default style for span and paragraph properties is normal. It internally inherits the default style of the document loaded or document editor component.

## Style hierarchy

Each style initially checks its local value for the property that is being evaluated and turns to the style it is based on. If no local value is found, it turns to its default style.

Style inheritance of different styles are listed as follows:

### Character style

Character styles are based only on other character styles.

The inheritance is: Character properties are inherited from the base character style.

### Paragraph style

Paragraph styles are based on other paragraph styles or on linked styles.
When a paragraph style is based on another paragraph style, the inheritance of the properties is as follows:
* Paragraph properties are inherited from the base paragraph style.
* Span properties are inherited from the base paragraph style.

When a paragraph style is based on a linked style, the inheritance of the properties is as follows:
* Paragraph properties are inherited from the paragraph style part in its base linked style.
* Span properties are inherited from the span style part in its base linked style.

### Linked style

Linked styles are composite styles and their components are paragraph and character styles with link between them. To apply paragraph properties, take the properties from the linked paragraph style. Similarly, to apply character properties, take the properties from linked character style.
Linked styles are based on other linked styles or on paragraph styles.

When a linked style is based on a paragraph style, the hierarchy of the properties is as follows:

* Paragraph properties are inherited from the ‘basedOn’ paragraph style.
* Character properties are inherited from the ‘basedOn’ paragraph style.

When a linked style is based on another linked style, the hierarchy of the properties is as follows:

* Paragraph properties are inherited from the paragraph style part in its base linked style.
* Span properties are inherited from the span style part in its base linked style.

## Defining new styles

New Styles are defined and added to the style collection of the document. In this way, they will be discovered by the default UI and applied to the parts of a document.

### Defining a character style

The following example shows how to programmatically create a character style.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/character-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Character-style.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/character-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Character-style.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



### Defining a paragraph style

The following example shows how to programmatically create a paragraph style.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/paragraph-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paragraph-style.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/paragraph-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paragraph-style.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



### Defining a linked style

The following example shows how to programmatically create linked style.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/linked-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Linked-style.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/linked-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Linked-style.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



### Applying a style

The styles are applied using the **applyStyle** method of **editorModule**, the parameter should be passed is the **Name** of the Style.

The styles of the **Character** type is applied to the currently selected part of the document. If there is no selection, the values that will be applied to the word at caret position. The styles of **Paragraph** type follow the same logic and are applied to all paragraphs in the selection or the current paragraph.

When there is no selection, styles of **Linked** type will change the values of the paragraph, and apply both the Paragraph and Character properties. When there is selection, Linked Style changes only the character properties of the selected text.

For example, the following line will apply the "New Linked" to the current paragraph.

```typescript
documenteditor.editor.applyStyle('New Linked');
//Clear direct formatting and apply the specified style
documenteditor.editor.applyStyle('New Linked', true);
```
