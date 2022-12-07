---
layout: post
title: Comments in ##Platform_Name## Document Editor Component
description: Learn here all about comments in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Comments
publishingplatform: ##Platform_Name##
documentation: ug
---


# Comments in Document Editor Component

Document editor allows to add comments to documents. You can add, navigate and remove comments in code and from the UI.

## Add a new comment

Comments can be inserted to the selected text.

```typescript
documentEditor.editor.insertComment("Test comment");
```

## Comment navigation

Next and previous comments can be navigated using the below code snippet.

```typescript
//Navigate to next comment
documentEditor.selection.navigateNextComment();

//Navigate to previous comment
documentEditor.selection.navigatePreviousComment();
```

## Delete comment

Current comment can be deleted using the below code snippet.

```typescript
documentEditor.editor.deleteComment();
```

## Delete all comment

All the comments in the document can be deleted using the below code snippet.

```typescript
documentEditor.editor.deleteAllComments();
```

## Protect the document in comments only mode

Document Editor provides support for protecting the document with `CommentsOnly` protection. In this protection, user is allowed to add or edit comments alone in the document.

Document editor provides an option to protect and unprotect document using [`enforceProtection`](../api/document-editor/editor/#enforceprotection) and [`stopProtection`](../api/document-editor/editor/#stopprotection) API.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/comment-only-protect/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Comment-only.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/comment-only-protect/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Comment-only.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


Comment only protection can be enabled in UI by using [Restrict Editing pane](../document-editor/document-management#restrict-editing-pane)

![Enable comment only protection](images/commentsonly.png)

>Note: In enforce Protection method, first parameter denotes password and second parameter denotes protection type. Possible values of protection type are `NoProtection |ReadOnly |FormFieldsOnly |CommentsOnly`. In stop protection method, parameter denotes the password.