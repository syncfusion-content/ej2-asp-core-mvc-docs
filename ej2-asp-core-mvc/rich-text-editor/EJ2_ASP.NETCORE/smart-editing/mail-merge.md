---
layout: post
title: Mail merge in ##Platform_Name## RichTextEditor | Syncfusion
description: Learn about Mail merge in Syncfusion ##Platform_Name## RichTextEditor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Mail merge
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mail merge in ##Platform_Name## Rich Text Editor control

The Rich Text Editor can be customized to implement **Mail Merge** functionality by inserting placeholders into the editor using custom toolbar items. These placeholders are later replaced with actual data to generate personalized content such as letters, invoices, and reports.

This feature simplifies the creation of dynamic documents by allowing users to insert merge fields that are automatically populated with real data during content generation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/mail-merge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/mail-merge/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/mail-merge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/mail-merge/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}