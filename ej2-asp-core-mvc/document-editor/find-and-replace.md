---
layout: post
title: Find And Replace in ##Platform_Name## Document Editor Component
description: Learn here all about Find And Replace in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Find And Replace
publishingplatform: ##Platform_Name##
documentation: ug
---


# Find and Replace

The document editor component searches a portion of text in the document through a built-in interface called `OptionsPane` or rich APIs. When used in combination with selection performs various operations on the search results like replacing it with some other text, highlighting it, making it bolder, and more.

## Options pane

This provides the options to search for a portion of text in the document. After search operation is completed, the search results will be displayed in a list and options to navigate between them. The current occurrence of matched text or all occurrences with another text can be replaced by switching to `Replace` tab. This pane is opened using the keyboard shortcut `CTRL+F`. You can also open it programmatically using the following sample code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/options-pane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Options-pane.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/options-pane/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Options-pane.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



You can close the options pane by pressing `Esc` key.

## Search

The `Search` module of Document Editor exposes the following APIs:

|API Name|Type |Description|
|---|---|---|
|[`findAll()`](../api/document-editor/search/#findall)| Method |Searches for specified text in the whole document and highlights it with yellow.|
|[`searchResults`](../api/document-editor/search/#searchresults) |Property |This is an instance of `SearchResults`.|
|[`find()`](../api/document-editor/search/#find) | Method |Find immediate occurrence of specified text from cursor position in the document and highlights it with yellow.|

### Find the immediate occurrence in the document

Using [`find()`](../api/document-editor/search/#find) method, you can find the immediate occurrence of specified text from current cursor position in the document.

The following example code illustrates how to use find in Document editor.

```typescript
documenteditor.search.find('Some text', 'None');
```

> Second parameter is optional parameter and it denotes find Options. Possible values of find options are `'None' |'WholeWord' |'CaseSensitive'| 'CaseSensitiveWholeWord'`.

### Find all the occurrences in the document

Using [`findAll()`](../api/document-editor/search/#findall) method, you can find all the occurrences of specified text in the whole document and highlight it with yellow.

The following example code illustrates how to find All the text in the document.

```typescript
documenteditor.search.findAll('Some text', 'None');
```

> Second parameter is optional parameter and it denotes find Options. Possible values of find options are `'None' |'WholeWord' |'CaseSensitive'| 'CaseSensitiveWholeWord'`.

## Search results

The `SearchResults` class provides information about the search results after a search operation is completed that can be identified using the `searchResultsChange` event. This will expose the following APIs:

|API Name|Type |Description|
|---|---|---|
|[`length`](../api/document-editor/searchResults/#length)|Property|Returns the total number of results found on the search.|
|[`index`](../api/document-editor/searchResults/#index)|Property|Returns the index of selected search result. You can change the value for this property to move the selection.|
|[`replaceAll()`](../api/document-editor/searchResults/#replaceall)|Method|Replaces all the occurrences with specified text.|
|[`clear()`](../api/document-editor/searchResults/#clear)|Method|Clears the search result.|

### Replace all the occurrences

Using [`replaceAll`](../api/document-editor/searchResults/#replaceall), you can replace all the occurrences with specified text.

The following example code illustrates how to use replace All in Document editor.

```typescript
documentEditor.search.findAll ('Some text');
// Replace all the searched text with word 'Mike'
documentEditor.search.searchResults.replaceAll("Mike");  
```

### Replace

Using [`insertText`](../api/document-editor/editor/#inserttext), you can replace the current searched text with specified text and it replace single occurrence.

The following example code illustrates how to find a text in the document and replace each occurrence of the text one by one programmatically.

```typescript
container.documentEditor.search.findAll('works');

let searchLength: number = container.documentEditor.search.searchResults.length;

for (let i = 0; i < searchLength; i++) {
  // It will move selection to specific searched index,move to each occurrence one by one
  container.documentEditor.search.searchResults.index = i;
  // Replace it with some text
  container.documentEditor.editor.insertText('Hello');
}

container.documentEditor.search.searchResults.clear();
```

## SearchResultsChange event

`DocumentEditor` exposes the `searchResultsChange’`event that will be triggered whenever search results are changed. Consider the following scenarios:

* A search operation is completed with some results.
* The results are replaced with some other text, since it will be cleared automatically.
* The results are cleared explicitly.

Refer to the following code example.

```typescript
documenteditor.searchResultsChange = function() {

};
```

## Customize find and replace

Using the exposed APIs, you can customize the find and replace functionality in your application. Refer to the following sample code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/find-replace/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Find-replace.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/find-replace/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Find-replace.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## See Also

* [Options pane](../../document-editor/dialog.html#options-pane)
* [Feature modules](../../document-editor/feature-module/)
