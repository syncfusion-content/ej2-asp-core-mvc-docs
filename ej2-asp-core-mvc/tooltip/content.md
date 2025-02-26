---
layout: post
title: Content in ##Platform_Name## Tooltip Control | Syncfusion
description: Learn here all about Content in Syncfusion ##Platform_Name## Tooltip component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Content
publishingplatform: ##Platform_Name##
documentation: ug
---


# Content in Tooltip Control

A text or a piece of information assigned to the Tooltip's `content` property will be displayed as the main text stream of the Tooltip. It can be a string or a template content. If the `content` property is not provided with any specific value, then it takes the value assigned to the `title` attribute of the target element on which the Tooltip was initialized. The content can also dynamically be assigned to the Tooltip via Fetch.

## Template content

Any text or image can be added to the Tooltip, by default. To customize the Tooltip layout or to create your own visualized element on the Tooltip, template can be used.

Refer to the following code example to add formatted HTML content to the Tooltip.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/tooltip/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/tooltip/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Content](./images/tooltip-content.png)

## Load dynamic Tooltip content

The Tooltip content can be dynamically loaded  by making use of the Fetch call. The Fetch request is usually made within the `beforeRender` event of the Tooltip, and then the Tooltip's `content` is assigned the value retrieved on it's success.

N> The Tooltip **target** property includes a unique identifier used to associate Tooltips with specific elements on a webpage or application interface. When setting the Tooltip **target** value as a GUID (Globally Unique Identifier), it's important to note that the GUID must start with a combination of **letters** before the numeric portion of the GUID. For example, **target: '#' +  ' tooltip'+ '96ad88bd-294c-47c3-999b-a9daa3285a05'**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/ajaxcontent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AjaxContent.cs" %}
{% include code-snippet/tooltip/ajaxcontent/ajaxcontent.cs %}
{% endhighlight %}
{% highlight c# tabtitle="tooltipdata.json" %}
{% include code-snippet/tooltip/ajaxcontent/tooltipdata.json %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/ajaxcontent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AjaxContent.cs" %}
{% include code-snippet/tooltip/ajaxcontent/ajaxcontent.cs %}
{% endhighlight %}
{% highlight c# tabtitle="tooltipdata.json" %}
{% include code-snippet/tooltip/ajaxcontent/tooltipdata.json %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core - Tooltip - Dynamic Content via Ajax](./images/dynamic-content.png)
