---
layout: post
title: Form Support in ##Platform_Name## Uploader Component
description: Learn here all about Form Support in Syncfusion ##Platform_Name## Uploader component and more.
platform: ej2-asp-core-mvc
control: Form Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# Forms Support (Synchronous Upload)

The Uploader control works with HTML form like default file input. The following configuration is must to make the Uploader work inside the form.

    *   `saveUrl` and `removeUrl` must be null.
    *   `autoUpload` must be disabled.
    *   `name` attribute must be added in input element.

The selected or dropped files are received as a collection in form action when the form is submitted.
The form action handles the server-side operations that manage the file upload process.
When you reset the form, the file list and data will be cleared.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/uploader/form-support/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/form-support/index.css %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/uploader/form-support/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.css" %}
{% include code-snippet/uploader/form-support/index.css %}
{% endhighlight %}
{% endtabs %}
{% endif %}


