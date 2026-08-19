---
layout: post
title: How to trigger input-file click externally | Syncfusion
description: Trigger the input file click event from an external button in the Syncfusion ASP.NET Core File Upload by binding a click handler to invoke the hidden input.
platform: ej2-asp-core-mvc
control: Trigger Click Event Of Input File From External Button
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to trigger input-file click from an external button

You can trigger the click event of input file from external button using `click` event of button. In the below sample, triggered click event of input file from `Essential JavaScript 2 Button`.

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


N> You can also explore [ASP.NET Core File Upload](https://www.syncfusion.com/aspnet-core-ui-controls/file-upload) feature tour page for its groundbreaking features. You can also explore our [ASP.NET Core File Upload example](https://ej2.syncfusion.com/aspnetcore/uploader/defaultfunctionalities#/fluent2) to understand how to browse the files which you want to upload to the server.