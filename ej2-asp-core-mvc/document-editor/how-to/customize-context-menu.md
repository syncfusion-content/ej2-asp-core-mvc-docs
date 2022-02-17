---
layout: post
title: Customize Context Menu in ##Platform_Name## Document Editor Component
description: Learn here all about Customize Context Menu in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Customize Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Context menu customization

## How to customize context menu in Document Editor

Document Editor allows you to add custom option in context menu. It can be achieved by using the `addCustomMenu()` method and custom action is defined using the `customContextMenuSelect`.

### Add Custom Option

The following code shows how to add custom option in context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/add-custom-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Add-custom-menu.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/add-custom-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Add-custom-menu.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



### Customize custom option in context menu

Document Editor allows you to customize the added custom option and also to hide/show default context menu.

#### Hide default context menu items

Using `addCustomMenu()` method, you can hide the default context menu. By setting second parameter as true.

The following code shows how to hide default context menu and add custom option in context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/hide-context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-context-menu.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/hide-context-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hide-context-menu.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



#### Customize added context menu items

The following code shows how to hide/show added custom option in context menu using the `customContextMenuBeforeOpen`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/customize-context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-context-menu.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/customize-context-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-context-menu.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

