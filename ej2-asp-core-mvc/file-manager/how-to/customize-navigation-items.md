---
layout: post
title: Customize navigation items in ##Platform_Name## File Manager | Syncfusion
description: Learn how to customize the navigation pane in the ##Platform_Name## File Manager by templating each folder node to show extra metadata or custom icons.
control: File Manager
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize the navigation pane in ##Platform_Name## File Manager

The navigation pane in the File Manager Control displays the folder hierarchy in a tree-like structure. You can customize the layout of each folder node in the navigation pane using the `navigationPaneTemplate` property. This allows you to modify the appearance of folders based on your application's requirements.

You may use this template to show additional metadata, custom icons, or other UI elements alongside the folder name.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/navigation-pane-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/file-manager/navigation-pane-template/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/navigation-pane-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/navigation-pane-template/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}