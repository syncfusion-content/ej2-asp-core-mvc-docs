---
layout: post
title: Restrict Particular Content in ##Platform_Name## Document Editor Component
description: Learn how to Restrict Particular Content from the Syncfusion ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Restrict Particular Content
publishingplatform: ##Platform_Name##
documentation: ug
---

# Restrict Particular Content in  Document editor control

In this article, we are going to see how to restrict particular content during selection.

## Following are the steps to restrict a specific content when selecting the desired content:

1. Select any content you wish to make non-editable.
2. Add a button. A bookmark with a unique ID beginning with "Placeholder_" will be created for the selected content.
3. If the selection falls within this bookmark, the control will be set to read-only.
4. The selected content is now restricted and cannot be edited (non-editable).


The following example code illustrates how to restrict particular content during selection.



{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/restrict-content/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Restrict-content.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/restrict-content/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Restrict-content.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}
