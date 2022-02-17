---
layout: post
title: Enable Disable Toolbar Item in ##Platform_Name## File Manager Component
description: Learn here all about Enable Disable Toolbar Item in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: Enable Disable Toolbar Item
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to enable/disable toolbar item/items

The toolbar items can be enabled/disabled by specifying the items in `enableToolbarItems` or `disableToolbarItems` methods respectively.

The following example shows enabling and disabling toolbar items on button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/file-manager/toolbar-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/toolbar-items/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/file-manager/toolbar-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/file-manager/toolbar-items/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below when enable toolbar item.

![FileManager enable toolbar items ](../images/enable_toolbar_items.PNG)

Output be like the below when enable toolbar item.

![FileManager disable toolbar items ](../images/disable_toolbar_items.PNG)