---
layout: post
title: Views in ##Platform_Name## File Manager Control | Syncfusion
description: Learn here all about Views in Syncfusion ##Platform_Name## File Manager control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Views
publishingplatform: ##Platform_Name##
documentation: ug
---


# Views

The view section displays files and folders for user browsing. The `view` API can also be used to change the initial view of the File Manager.

The File Manager has two types of `views` to display the files and folders.

* [LargeIcons View](#largeicons-view)
* [Details View](#details-view)

## LargeIcons View

By default, File Manager is rendered with the largeicons view. The following example demonstrates this.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/large-icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/large-icons/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/large-icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/large-icons/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below.

![File Manager largeicons view](./images/large_icons.PNG)

## Details View

The default appearance of the File Manager can be changed from largeicons to details view by using the `view` property. In the Details view, the files are displayed in a sorted list order. This file list comprises of several columns of information about the files such as **Name**, **Date Modified**, **Type**, and **Size**. The following example demonstrates the File Manager with details view.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/overview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/overview/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/overview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/overview/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below.

![File Manager details view](./images/overview.PNG)
