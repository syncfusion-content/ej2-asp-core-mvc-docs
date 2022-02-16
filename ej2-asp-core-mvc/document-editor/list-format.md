---
layout: post
title: List Format in ##Platform_Name## Document Editor Component
description: Learn here all about List Format in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: List Format
publishingplatform: ##Platform_Name##
documentation: ug
---


# Working with Lists

Document editor supports both the single-level and multilevel lists. Lists are used to organize data as step-by-step instructions in documents for easy understanding of key points. You can apply list to the paragraph either using supported APIs.

## Create bullet list

Bullets are usually used for unordered lists. To apply bulleted list for selected paragraphs, use the following method of ‘Editor’ instance.

> applyBullet(bullet, fontFamily);

|Parameter|Type|Description|
|---------|----|-----------|
|Bullet|string|Bullet character.|
|fontFamily|string|Bullet font family.|

Refer to the following sample code.

```typescript
documenteditor.editor.applyBullet('\uf0b7', 'Symbol');
```

## Create numbered list

Numbered lists are usually used for ordered lists. To apply numbered list for selected paragraphs, use the following method of ‘Editor’ instance.

> applyNumbering(numberFormat,listLevelPattern)

|Parameter|Type|Description|
|---------|----|-----------|
|numberFormat|string|“%n” representations in ‘numberFormat’ parameter will be replaced by respective list level’s value.“%1)” will be displayed as “1)”|
|listLevelPattern(optional)|string|Default value is 'Arabic'.|

Refer to the following example.

```typescript
documenteditor.editor.applyNumbering('%1)', 'UpRoman');
```

## Clear list

You can also clear the list formatting applied for selected paragraphs. Refer to the following sample code.

```typescript
documenteditor.editor.clearList();
```

## Working with lists

The following sample demonstrates how to create bullet and numbering lists in document editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/list/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/list/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Editing numbered list

Document editor restarts the numbering or continue numbering for a numbered list. These options are found in the built-in context menu, if the list value is selected. Refer to the following screenshot.

![Image](images/list.JPG)

## See Also

* [List dialog](../../document-editor/dialog/#list-dialog)
