---
layout: post
title: Customize the Navigation Pane in ##Platform_Name## File Manager Control | Syncfusion
description: Learn here all about Customize the Navigation Pane in Syncfusion ##Platform_Name## File Manager control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize the Navigation Pane
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize Navigation Pane in File Manager Control

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