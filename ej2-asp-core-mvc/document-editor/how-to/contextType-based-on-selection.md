---
layout: post
title: ContextType Based on selection in ##Platform_Name## Document Editor Component
description: Learn how to ContextType Based on selection in Document from the ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: ContextType Based on selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Determine the context type of the current cursor position based on the selection in the Document in ##Platform_Name## Document editor control

You can utilize the contextType API within the selection module to determine whether the current cursor is positioned in the table,text and so on.

## Get the ContextType based on selected content

You can use [`contextType`]API to get the contextType based on the selected content in the Document Editor component.

The following example code illustrates how to determine the context type of the current cursor position based on the selection in the Document.

* Click the Button while selecting the specific context type.
* This will get the context type and result to show the  contextType based on the selected content in the Document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/context-type-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="context-type-selection.cs" %}
{% include code-snippet/document-editor-container/context-type-selection/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/context-type-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Context-type-selection.cs" %}
{% include code-snippet/document-editor-container/context-type-selection/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}