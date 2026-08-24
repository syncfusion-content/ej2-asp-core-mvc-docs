---
layout: post
title: How to clear an image in ##Platform_Name## ImageEditor | Syncfusion
description: Programmatically clear edits from a Syncfusion ##Platform_Name## ImageEditor canvas using the clearImage and reset methods after destructive operations.
platform:  ej2-asp-core-mvc
control: Clear Image
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Clear an Image ##Platform_Name## Image Editor control

The `clearImage` method in the image editor control is indeed useful for scenarios where you need to ensure that the image editor is emptied before reopening it, especially if the editor is used within a dialog. By using clearImage before closing the dialog, you can ensure that the editor does not retain the previously loaded image when the dialog is reopened. This allows users to start fresh with a new image selection.

Here is an example of clearing an Image using `clearImage` method. 

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/how-to/clear-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/how-to/clear-image/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/how-to/clear-image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/how-to/clear-image/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](../images/image-editor-clear-image.png)