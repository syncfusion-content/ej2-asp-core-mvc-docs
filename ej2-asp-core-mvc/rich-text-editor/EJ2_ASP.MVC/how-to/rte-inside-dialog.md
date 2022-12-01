---
layout: post
title: RichTextEditor inside the Dialog Component | Syncfusion
description: This section explains about rendering the Blazor RichTextEditor component inside the Dialog component.
platform: ej2-asp-core-mvc
control: Dialog inside the Rich Text Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# RichTextEditor inside the Dialog Component

While rendering the Rich Text Editor inside the Dialog component, the dialog container and its wrapper elements are styled with display as none, so the editor’s toolbar does not get proper offset width and will render above the edit area container. To resolve this issue, you can call the refreshUI method of RichTextEditor in the Dialog open event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/inside-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inside.cs" %}
{% include code-snippet/rich-text-editor/how-to/inside-dialog/inside.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/inside-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inside.cs" %}
{% include code-snippet/rich-text-editor/how-to/inside-dialog/inside.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}