---
layout: post
title: Link in ##Platform_Name## Document Editor Component | Syncfusion
description: Learn here all about Link in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Link
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hyperlink in Document Editor Component

Document editor supports hyperlink field. You can link a part of the document content to Internet or file location, mail address, or any text within the document.

## Navigate a hyperlink

Document editor triggers ‘requestNavigate’ event whenever user clicks Ctrl key or tap a hyperlink within the document. This event provides necessary details about link type, navigation URL, and local URL (if any) as arguments, and allows to easily customize the hyperlink navigation functionality.

### Add the requestNavigate event for DocumentEditor

The following example illustrates how to add requestNavigate event for DocumentEditor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/hyperlink/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/hyperlink/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/hyperlink/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/hyperlink/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Add the requestNavigate event for DocumentEditorContainer component

The following example illustrates how to add requestNavigate event for DocumentEditorContainer component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/link/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/link/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/link/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/link/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

If the selection is in hyperlink, trigger this event by calling ‘navigateHyperlink’ method of ‘Selection’ instance.

```typescript
documenteditor.selection.navigateHyperlink();
```

## Copy link

Document editor copies link text of a hyperlink field to the clipboard if the selection is in hyperlink.

```typescript
documenteditor .selection.copyHyperlink();
```

## Add hyperlink

To create a basic hyperlink in the document, press `ENTER` / `SPACEBAR` / `SHIFT + ENTER` / `TAB` key after typing the address, for instance `http://www.google.com`. Document editor automatically converts this address to a hyperlink field. The text can be considered as a valid URL if it starts with any of the following.

N> `<http://>`<br>
<br/> `<https://>`<br>
<br/> `file:///`<br>
<br/> `www.`<br>
<br/> `mailto:`<br>

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/hyperlink-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/hyperlink-edit/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/hyperlink-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/hyperlink-edit/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customize screen tip

You can customize the screen tip text for the hyperlink by using below sample code.

```typescript
documenteditor.insertHyperlink('https://www.google.com', 'Google', '<<Screen tip text>>');
```

Screen tip text can be modified through UI by using the [Hyperlink dialog](../document-editor/dialog#hyperlink-dialog)

![Add or modify the screen tip text for hyperlinks in a Word document.](images/screentip.png)

## Remove hyperlink

To remove link from hyperlink in the document, press Backspace key at the end of a hyperlink. By removing the link, it will be converted as plain text. You can use ‘removeHyperlink’ method of ‘Editor’ instance if the selection is in hyperlink.

```typescript
documenteditor.editor.removeHyperlink();
```

## Hyperlink dialog

Document editor provides dialog support to insert or edit a hyperlink.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/hyperlink-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/hyperlink-dialog/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/hyperlink-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/hyperlink-dialog/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



You can use the following keyboard shortcut to open the hyperlink dialog if the selection is in hyperlink.

| Key Combination | Description |
|-----------------|-------------|
|Ctrl + K | Open hyperlink dialog that allows you to create or edit hyperlink|

## See Also

* [Feature modules](../document-editor/feature-module/)
* [Hyperlink dialog](../document-editor/dialog/#hyperlink-dialog)
