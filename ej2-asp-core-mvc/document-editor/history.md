---
layout: post
title: History in ##Platform_Name## Document Editor Component
description: Learn here all about History in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: History
publishingplatform: ##Platform_Name##
documentation: ug
---


# History

Document editor tracks the history of all editing actions done in the document, which allows undo and redo functionality.

## Enable or disable history

Inject the `EditorHistory` module in your application to provide history preservation functionality for `DocumentEditor`. Refer to the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/history/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="History.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/history/razor %}
{% endhighlight %}
{% highlight c# tabtitle="History.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



You can enable or disable history preservation for a document editor instance any time using the `enableEditorHistory` property. Refer to the following sample code.

```typescript
editor.enableEditorHistory = false;
```

## Undo and redo

You can perform undo and redo by `CTRL+Z` and `CTRL+Y` keyboard shortcuts. Document editor exposes API to do it programmatically.
To undo the last editing operation in document editor, refer to the following sample code.

```typescript
editor.editorHistory.undo();
```

To redo the last undone action, refer to the following code example.

```typescript
editor.editorHistory.redo();
```

## Stack size

History of editing actions will be maintained in stack, so that the last item will be reverted first. By default, document editor limits the size of undo and redo stacks to 500 each respectively. However, you can customize this limit. Refer to the following sample code.

```typescript
editor.editorHistory.undoLimit = 400;
editor.editorHistory.redoLimit = 400;
```

## See Also

* [Feature modules](../../document-editor/feature-module/)
* [Keyboard shortcuts](../../document-editor/keyboard-shortcut/)
