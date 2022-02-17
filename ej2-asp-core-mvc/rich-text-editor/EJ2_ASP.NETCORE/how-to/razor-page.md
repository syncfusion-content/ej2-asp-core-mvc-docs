---
layout: post
title: Razor Page in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Razor Page in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Razor Page
publishingplatform: ##Platform_Name##
documentation: ug
---


# Model Binding in Razor Pages

This article deals with the model binding of the Razor Pages of the ASP.NET Core platform.
Refer to this [`Page Model`](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/page-model-binding/) section for the detailed instructions on how to create a page model.
The model binding provides data to the page models and Razor pages. OnGet is a handler method that will be executed once the Razor page gets loaded in the browser. `value` in the form tag retrieves data from the OnGet method in the `IndexModel` class using the model binding.

## Form Post Back

This sample explains the form post back properties of the rich text editor rendering with the razor page.
The Rich text editor is rendered within the form tag and the value `post` and attribute `method` has been given into the form tag. Any value into the `Request.Form` in the OnPost method will be considered as a string and those string should be mapped to the name field of the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/razor-page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/rich-text-editor/how-to/razor-page/index.cshtml.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
{% include code-snippet/rich-text-editor/how-to/razor-page/index.cshtml.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

