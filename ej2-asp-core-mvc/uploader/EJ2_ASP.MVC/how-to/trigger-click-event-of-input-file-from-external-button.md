---
layout: post
title: How to trigger input-file click externally in ##Platform_Name## | Syncfusion
description: Trigger the input file click event from an external button in the Syncfusion ASP.NET MVC File Upload by binding a click handler to invoke the hidden input.
platform: ej2-asp-core-mvc
control: Trigger Click Event Of Input File From External Button
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to trigger the input-file click event from an external button

You can trigger the click event of the input file from an external button using the `click` event of the button. In the following sample, the click event of the input file is triggered from the `Essential JavaScript 2 Button`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/external-click/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/external-click/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/external-click/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/external-click/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> Explore the [ASP.NET MVC File Upload](https://www.syncfusion.com/aspnet-mvc-ui-controls/file-upload) feature tour page to discover its groundbreaking features. You can also check out our [ASP.NET MVC File Upload example](https://ej2.syncfusion.com/aspnetmvc/uploader/defaultfunctionalities#/fluent2) to see how to browse and select files for upload to the server.