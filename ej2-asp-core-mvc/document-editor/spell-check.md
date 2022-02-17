---
layout: post
title: Spell Check in ##Platform_Name## Document Editor Component
description: Learn here all about Spell Check in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Spell Check
publishingplatform: ##Platform_Name##
documentation: ug
---


# Spell Check

Document editor supports performing spell checking for any input text. You can perform spell checking for the text in Document Editor and it will provide suggestions for the mis-spelled words through dialog and in context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/spell-checker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Spell-checker.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/spell-checker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Spell-checker.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Features

* Supports context menu suggestions.
* Provides build-in options to Ignore, Ignore All, Change, Change All for error words in spell checker        dialog.

## Enable SpellCheck

To enable spell check in DocumentEditor, set `enableSpellCheck` property as `true` and then configure SpellCheckSettings.

## Disable SpellCheck

To disable spell check in DocumentEditor, set `enableSpellCheck` property as `false` or remove `enableSpellCheck` property initialization code. The default value of this property is false.

## Spell check settings

### Remove Underline

By default, mis-spelled words are marked with squiggly line. You can also disable this behavior by enabling the `removeUnderline` API and now, the squiggly lines will never be rendered for mis-spelled words.

```typescript
this.container.documentEditor.spellChecker.removeUnderline = false;
```

### AllowSpellCheckAndSuggestion

By default, on performing spell check in Document Editor, both spelling and suggestions of the mis-spelled words will be retrieved, and this mis-spelled words can be corrected through context menu suggestions. You can modify this behavior using the `allowSpellCheckAndSuggestion` API, which will perform only spell check.

```typescript
this.container.documentEditor.spellChecker.allowSpellCheckAndSuggestion = false;
```

### LanguageID

Document Editor provides multi-language spell check support. You can add as many languages (dictionaries) in the server-side and to use that language for spell checking in Document Editor, it must be matched with `languageID` you pass in the Document Editor.

```typescript
this.container.documentEditor.spellChecker.languageID = 1033; //LCID of "en-us";
```

### EnableOptimizedSpellCheck

Document editor provides option to spellcheck page by page when loading the documents. The default value of this property is false, so when opening the document spellcheck web API will be called for each word in the document. To optimize the frequency of spellcheck web API calls, you can enable this property.

The following code example illustrates how to enable optimized spell checking.

```typescript
this.container.documentEditor.spellChecker.enableOptimizedSpellCheck = true;
```

## Context menu

Right click on error word to open the context menu with spell check options. Please see below screenshot for your reference.

![Spell check option in context menu](images/spell-check-menu.png)

### Suggestions

Context menu shows the suggestions for mis-spelled words. By clicking on the required word from suggestion, the error word gets replaced automatically.

### Add To Dictionary

Using this option, you can add the current word to the dictionary. So that the spell checker does not consider that word as error in future.

### Ignore Once and Ignore All

If you do not wish to add the word to dictionary and do not want to show error, use Ignore Once or Ignore All options.

Ignore: ignore only the current occurrence of a word from error.

Ignore All: ignore all occurrence of a word from error in the entire document.

### Spelling

Using this option, you can open spell check dialog. Please see below screenshot for your reference.

![Spell check dialog](images/spell-check-dialog.png)

* Refer to the [Spell checker](https://github.com/SyncfusionExamples/EJ2-DocumentEditor-WebServices) link for configuring spell checker in server-side.