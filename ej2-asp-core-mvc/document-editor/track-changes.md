---
layout: post
title: Track Changes in ##Platform_Name## Document Editor Control | Syncfusion
description: Learn here all about track changes in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Track Changes
publishingplatform: ##Platform_Name##
documentation: ug
---

# Track Changes in Document Editor Component

Track Changes allows you to keep a record of changes or edits made to a document. You can then choose to accept or reject the modifications. It is a useful tool for managing changes made by several reviewers to the same document. If track changes option is enabled, all editing operations are preserved as revisions in Document Editor.

## Enable track changes in Document Editor

The following example demonstrates how to enable track changes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/track-changes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Track-changes-only.cs" %}
{% include code-snippet/document-editor-container/track-changes/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/track-changes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Track-changes-only.cs" %}
{% include code-snippet/document-editor-container/track-changes/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

>Track changes are document level settings. When opening a document, if the document does not have track changes enabled, then enableTrackChanges will be disabled even if we set enableTrackChanges = true in the initial rendering. If you want to enable track changes for all the documents, then we recommend enabling track changes during the document change event. The following example demonstrates how to enable Track changes for the all the Document while Opening.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/track-changes-default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Track-changes-default.cs" %}
{% include code-snippet/document-editor-container/track-changes-default/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/track-changes-default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Track-changes-default.cs" %}
{% include code-snippet/document-editor-container/track-changes-default/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
## Show/Hide Revisions Pane
 
The Show/Hide Revisions Pane feature in the Document Editor allows users to toggle the visibility of the revisions pane, providing flexibility in managing tracked changes within the document.
 
The following example code illustrates how to show/hide the revisions pane.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/toggle-track-pane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Track-changes-only.cs" %}
{% include code-snippet/document-editor-container/toggle-track-pane/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/toggle-track-pane/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Track-changes-only.cs" %}
{% include code-snippet/document-editor-container/toggle-track-pane/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Get all tracked revisions

The following example demonstrate how to get all tracked revision from current document.

```typescript
/**
 * Get revisions from the current document
 */
var revisions  = container.documentEditor.revisions;
```

## Accept or Reject all changes programmatically

The following example demonstrates how to accept/reject all changes.

```typescript
/**
 * Get revisions from the current document
 */
var revisions = container.documentEditor.revisions;

/**
 * Accept all tracked changes
 */
revisions.acceptAll();

/**
 * Reject all tracked changes
 */
revisions.rejectAll();
```

## Accept or reject a specific revision

The following example demonstrates how to accept/reject specific revision in the Document Editor.

```typescript
/**
 * Get revisions from the current document
 */
var revisions  = container.documentEditor.revisions;
/**
 * Accept specific changes
 */
revisions.get(0).accept();
/**
 * Reject specific changes
 */
revisions.get(1).reject();
```

## Navigate between the tracked changes

The following example demonstrates how to navigate tracked revision programmatically.

```typescript
/**
 * Navigate to next tracked change from the current selection.
 */
container.documentEditor.selection.navigateNextRevision();

/**
 * Navigate to previous tracked change from the current selection.
 */
container.documentEditor.selection.navigatePreviousRevision();
```

## Filtering changes based on user

In DocumentEditor, we have built-in review panel in which we have provided support for filtering changes based on the user.

![Track changes](images/track-changes.png)

## Protect the document in track changes only mode

Document Editor provides support for protecting the document with `RevisionsOnly` protection. In this protection, all the users are allowed to view the document and do their corrections, but they cannot accept or reject any tracked changes in the document. Later, the author can view their corrections and accept or reject the changes.

Document editor provides an option to protect and unprotect document using `enforceProtection` and `stopProtection` API.

The following example code illustrates how to enforce and stop protection in Document editor container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/track-changes-only-protect/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Track-changes-only.cs" %}
{% include code-snippet/document-editor-container/track-changes-only-protect/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/track-changes-only-protect/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Track-changes-only.cs" %}
{% include code-snippet/document-editor-container/track-changes-only-protect/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Tracked changes only protection can be enabled in UI by using [Restrict Editing pane](../document-editor/document-management#restrict-editing-pane/)

![Enable track changes only protection](images/tracked-changes.png)

N> In enforce Protection method, first parameter denotes password and second parameter denotes protection type. Possible values of protection type are `NoProtection |ReadOnly |FormFieldsOnly |CommentsOnly |RevisionsOnly`. In stop protection method, parameter denotes the password.

## To Hide the revision pane

When turning on the track change mode, every time we click on new/edited text, the track change/comment side panel will show automatically. 

The following example code illustrates how to hide the revision pane in Document editor container.


```typescript
/**
 * To hide track changes pane
 */
container.documentEditor.showRevisions = false;
}

```
